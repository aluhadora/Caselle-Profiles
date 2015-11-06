using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaselleProfiles.DTO;
using CaselleProfiles.Utilities;

namespace CaselleProfiles.Processes
{
  public static class ProfilesProcess
  {
    private const string Directory = "Directory";
    private const string Name = "Name";
    private const string Order = "Order";

    public static IList<Profile> Load()
    {
      var profiles = new List<Profile>();

      var reg = new RegistryEditor(false);
      foreach (var name in reg.ReadKeys())
      {
        profiles.Add(BuildProfile(name));
      }

      return profiles.OrderBy(x => x.Order).ToList();
    }

    private static Profile BuildProfile(string name)
    {
      var _reg = new RegistryEditor(false);

      _reg.ProfileName = name; //todo this is bad, make this thread-safe
      return new Profile
      {
        Directory = _reg.Read(Directory),
        Name = _reg.Read(Name),
        Order = _reg.ReadInt(Order) ?? 0,
      };
    }

    public static void Save(IList<Profile> profiles)
    {
      var reg = new RegistryEditor(false);
      reg.DeleteSubKeyTree();

      var order = 0;

      foreach (var profile in profiles)
      {
        reg.ProfileName = profile.Name;  //todo this is bad, make this thread-safe
        reg.Write(Name, profile.Name);
        reg.Write(Directory, profile.Directory);
        reg.Write(Order, order++);
      }
    }
  }
}

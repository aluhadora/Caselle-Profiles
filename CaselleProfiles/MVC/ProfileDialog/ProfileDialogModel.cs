using System.Collections.Generic;
using System.Linq;
using CaselleProfiles.DTO;
using CaselleProfiles.Utilities;

namespace CaselleProfiles.MVC.ProfileDialog
{
  public class ProfileDialogModel
  {
    private const string Directory = "Directory";
    private const string Name = "Name";
    private const string Order = "Order";

    private readonly IProfileDialog _view;
    private RegistryEditor _reg;

    public ProfileDialogModel(IProfileDialog view)
    {
      _view = view;
      _view.Save += Save;
      _view.Load += Load;

      _reg = new RegistryEditor(false);
    }

    private void Load()
    {
      var profiles = new List<Profile>();

      foreach (var name in _reg.ReadKeys())
      {
        profiles.Add(BuildProfile(name));
      }

      _view.Profiles = profiles.OrderBy(x => x.Order).ToList();
    }

    private Profile BuildProfile(string name)
    {
      _reg.ProfileName = name; //todo this is bad, make this thread-safe
      return new Profile
      {
        Directory = _reg.Read(Directory),
        Name = _reg.Read(Name),
        Order = _reg.ReadInt(Order) ?? 0,
      };
    }

    private void Save()
    {
      _reg.DeleteSubKeyTree();
      var profiles = _view.Profiles;

      var order = 0;

      foreach (var profile in profiles)
      {
        _reg.ProfileName = profile.Name;  //todo this is bad, make this thread-safe
        _reg.Write(Name, profile.Name);
        _reg.Write(Directory, profile.Directory);
        _reg.Write(Order, order++);
      }
    }
  }
}

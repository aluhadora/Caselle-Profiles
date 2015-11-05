using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using CaselleProfiles.DTO;

namespace CaselleProfiles.Processes
{
  public static class TortoiseHGProcess
  {
    private const string RepoRepositoryLocation = @"TortoiseHg\thg-reporegistry.xml";
    
    private static string RepoRepository
    {
      get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), RepoRepositoryLocation); }
    }

    public static IList<Profile> BuildProfiles()
    {
      var profiles = GetUnverifiedProfiles();

      for (int i = profiles.Count - 1; i >= 0; i--)
      {
        if (!Directory.Exists(profiles[i].Directory)) profiles.RemoveAt(i);
      }

      return profiles;
    }

    private static IList<Profile> GetUnverifiedProfiles()
    {
      XmlReader xr = new XmlTextReader(RepoRepository);

      var profiles = new List<Profile>();

      while (xr.Read())
      {
        if (xr.Name != "repo") continue;

        var root = xr.GetAttribute("root");
        var shortname = xr.GetAttribute("shortname");

        profiles.Add(GenerateProfile(root, shortname));
      }

      return profiles;
    }

    private static Profile GenerateProfile(string root, string shortname)
    {
      return new Profile {Directory = root, Name = shortname};
    }
  }
}

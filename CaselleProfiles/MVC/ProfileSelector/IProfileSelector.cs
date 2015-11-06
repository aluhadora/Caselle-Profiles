using System;
using System.Collections.Generic;
using CaselleProfiles.DTO;

namespace CaselleProfiles.MVC.ProfileSelector
{
  public interface IProfileSelector
  {
    event Action<Profile> ProfileChanged;
    Profile CurrentProfile { get; set; }

    void FillNames(IList<string> profiles);
  }
}

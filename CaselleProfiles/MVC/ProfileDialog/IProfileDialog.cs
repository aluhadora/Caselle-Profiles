using System;
using System.Collections.Generic;
using CaselleProfiles.DTO;

namespace CaselleProfiles.MVC.ProfileDialog
{
  public interface IProfileDialog
  {
    event Action Save;
    event Action Load;

    IList<Profile> Profiles { get; set; } 
  }
}

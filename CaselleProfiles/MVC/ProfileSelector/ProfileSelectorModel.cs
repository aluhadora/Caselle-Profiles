using System.Collections.Generic;
using System.Linq;
using CaselleProfiles.DTO;
using CaselleProfiles.Processes;

namespace CaselleProfiles.MVC.ProfileSelector
{
  public class ProfileSelectorModel
  {
    private readonly IProfileSelector _view;

    public ProfileSelectorModel(IProfileSelector view)
    {
      _view = view;
    }

    public void Initialize()
    {
      Profiles = ProfilesProcess.Load();
      _view.FillNames(Profiles.Select(x => x.Name).ToList());
    }

    public IList<Profile> Profiles { get; private set; }
  }
}

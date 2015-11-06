using CaselleProfiles.Processes;
using CaselleProfiles.Utilities;

namespace CaselleProfiles.MVC.ProfileDialog
{
  public class ProfileDialogModel
  {
    private readonly IProfileDialog _view;

    public ProfileDialogModel(IProfileDialog view)
    {
      _view = view;
      _view.Save += Save;
      _view.Load += Load;
    }

    private void Load()
    {
      _view.Profiles = ProfilesProcess.Load();
    }

    private void Save()
    {
      ProfilesProcess.Save(_view.Profiles);
    }
  }
}

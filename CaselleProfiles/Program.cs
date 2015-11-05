using System;
using System.Windows.Forms;
using CaselleProfiles.MVC.ProfileDialog;

namespace CaselleProfiles
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      var profileDialog = new ProfileDialog();
      new ProfileDialogModel(profileDialog);
      Application.Run(profileDialog);
    }
  }
}

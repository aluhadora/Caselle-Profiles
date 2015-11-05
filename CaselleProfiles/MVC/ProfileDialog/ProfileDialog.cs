using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CaselleProfiles.DTO;
using CaselleProfiles.Processes;

namespace CaselleProfiles.MVC.ProfileDialog
{
  public partial class ProfileDialog : Form, IProfileDialog
  {
    public ProfileDialog()
    {
      InitializeComponent();
    }

    public void AddProfile(Profile profile)
    {
      var top = ProfileControls
          .Select(x => x.Bottom)
          .DefaultIfEmpty(12)
          .Max();

      var control = new ProfileControl
      {
        Profile = profile,
        Top = top + 3,
        Left = 12,
        Width = profilePanel.Width - 24,
        Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
      };

      control.RemoveButtonClicked += RemoveProfile;
      profilePanel.Controls.Add(control);
    }

    private void RemoveProfile(ProfileControl control)
    {
      control.RemoveButtonClicked -= RemoveProfile;
      profilePanel.Controls.Remove(control);

      foreach (var pc in ProfileControls)
      {
        pc.Top = 12 - pc.Height;
      }

      foreach (var pc in ProfileControls)
      {
        var top = ProfileControls
          .Select(x => x.Bottom)
          .DefaultIfEmpty(12)
          .Max();

        pc.Top = top + 3;
      }

      MoveAddButton();
    }

    private void MoveAddButton()
    {
      var bottom = ProfileControls
        .Select(x => x.Bottom)
        .DefaultIfEmpty(12)
        .Max();

      addButton.Top = bottom + 3;
    }

    private IEnumerable<ProfileControl> ProfileControls
    {
      get
      {
        return profilePanel.Controls.Cast<Control>()
          .Where(x => x is ProfileControl).Cast<ProfileControl>();
      }
    }

    private void OKClicked(object sender, EventArgs e)
    {
      DialogResult = DialogResult.OK;

      if (LocalSave != null) LocalSave();

      Close();
    }

    private void CancelClicked(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
      Close();
    }

    private void BuildProfiles(object sender, EventArgs e)
    {
      Clear();
      var profiles = TortoiseHGProcess.BuildProfiles();

      foreach (var profile in profiles)
      {
        AddProfile(profile);
      }

      AdjustLefts();

      MoveAddButton();
    }

    private void AdjustLefts()
    {
      var left = ProfileControls.Select(x => x.LabelWidth).DefaultIfEmpty(0).Max() + 3;

      foreach (var profileControl in ProfileControls)
      {
        profileControl.PanelWidth = left;
      }
    }

    private void Clear()
    {
      profilePanel.Controls.Clear();
      profilePanel.Controls.Add(addButton);
      addButton.Left = addButton.Top = 15;
    }

    private void addButton_Click(object sender, EventArgs e)
    {
      AddProfile(new Profile { Directory = "test", Name = "Test"});

      AdjustLefts();
      MoveAddButton();
    }

    private void ProfileDialog_Load(object sender, EventArgs e)
    {
      if (LocalLoad != null) LocalLoad();
    }

    #region Implementation of IProfileDialog

    private event Action LocalLoad;
    private event Action LocalSave;

    event Action IProfileDialog.Load
    { 
      add { LocalLoad += value; }
      remove { LocalLoad += value; }
    }
    
    event Action IProfileDialog.Save
    {
      add { LocalSave += value; }
      remove { LocalSave += value; }
    }

    IList<Profile> IProfileDialog.Profiles
    {
      get
      {
        var controls = ProfileControls;
        var profiles = new List<Profile>();

        foreach (var profileControl in controls)
        {
          profiles.Add(profileControl.Profile);
        }

        return profiles;
      }
      set
      {
        foreach (var profile in value)
        {
          AddProfile(profile);
        }

        AdjustLefts();
        MoveAddButton();
      }
    }

    #endregion
  }
}

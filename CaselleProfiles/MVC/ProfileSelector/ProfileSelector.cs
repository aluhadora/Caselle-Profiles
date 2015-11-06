using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CaselleProfiles.DTO;

namespace CaselleProfiles.MVC.ProfileSelector
{
  public partial class ProfileSelector : UserControl, IProfileSelector
  {
    private readonly ProfileSelectorModel _model; //todo this is bad =\

    public ProfileSelector()
    {
      InitializeComponent();

      _model = new ProfileSelectorModel(this);
      _model.Initialize();
    }

    #region Implementation of IProfileSelector

    private event Action<Profile> LocalProfileChanged;

    public event Action<Profile> ProfileChanged
    {
      add { LocalProfileChanged += value; }
      remove { LocalProfileChanged -= value; }
    }

    public Profile CurrentProfile
    {
      get { return _model.Profiles.FirstOrDefault(x => x.Name == profileComboBox.Text.Trim()); }
      set { profileComboBox.Text = value != null ? value.Name : string.Empty; }
    }

    void IProfileSelector.FillNames(IList<string> profiles)
    {
      profileComboBox.Items.Clear();
      profileComboBox.Items.AddRange(profiles.Cast<object>().ToArray());
    }

    public string ProfileName
    {
      get { return profileComboBox.Text; }
      set { profileComboBox.Text = value; }
    }

    #endregion

    private void profileComboBox_Click(object sender, EventArgs e)
    {

    }

    private void profileComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (LocalProfileChanged != null) LocalProfileChanged(CurrentProfile);
    }
  }
}

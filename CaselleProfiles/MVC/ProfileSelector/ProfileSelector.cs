using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CaselleProfiles.DTO;

namespace CaselleProfiles.MVC.ProfileSelector
{
  public partial class ProfileSelector : UserControl, IProfileSelector
  {
    private ProfileSelectorModel _model; //todo this is bad =\

    public ProfileSelector()
    {
      InitializeComponent();
    }

    public void Initialize()
    {
      _model = new ProfileSelectorModel(this);
      _model.Initialize();
    }

    private event Action<Profile> LocalProfileChanged;

    public event Action<Profile> ProfileChanged
    {
      add { LocalProfileChanged += value; }
      remove { LocalProfileChanged -= value; }
    }

    public bool OptionsVisible
    {
      get { return toolStripButton1.Visible; }
      set { toolStripButton1.Visible = value; }
    }

    public Profile CurrentProfile
    {
      get { return _model.Profiles.FirstOrDefault(x => x.Name == profileComboBox.Text.Trim()); }
      set { profileComboBox.Text = value != null ? value.Name : string.Empty; }
    }

    void IProfileSelector.FillNames(IList<string> profiles)
    {
      profileComboBox.Items.Clear();
      profileComboBox.Items.AddRange(Filter == null
        ? profiles.Cast<object>().ToArray()
        : profiles.Where(x => Filter(x)).Cast<object>().ToArray());
    }

    public string ProfileName
    {
      get { return profileComboBox.Text; }
      set { profileComboBox.Text = value; }
    }

    public event Action OptionsClicked;

    private void profileComboBox_Click(object sender, EventArgs e)
    {

    }

    private void profileComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (LocalProfileChanged != null) LocalProfileChanged(CurrentProfile);
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      if (OptionsClicked != null) OptionsClicked();
    }

    public Func<string, bool> Filter;
  }
}

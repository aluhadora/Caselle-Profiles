using System;
using System.Windows.Forms;
using CaselleProfiles.DTO;

namespace CaselleProfiles.MVC
{
  public partial class ProfileControl : UserControl
  {
    public ProfileControl()
    {
      InitializeComponent();
    }

    public Profile Profile
    {
      get
      {
        return new Profile
        {
          Directory = Directory,
          Name = ProfileName.Substring(0, ProfileName.LastIndexOf(" directory:"))
        };
      }
      set 
      { 
        ProfileName = value.Name + " directory:";
        Directory = value.Directory;
      }
    }

    public event Action<ProfileControl> RemoveButtonClicked;

    public int LabelWidth
    {
      get { return nameLabel.Width; }
    }

    public int PanelWidth
    {
      get { return labelPanel.Width; }
      set { labelPanel.Width = value; }
    }

    public string ProfileName
    {
      get { return nameLabel.Text; }
      set { nameLabel.Text = value; }
    }

    public string Directory
    {
      get { return folderBrowseBox1.FolderPath; }
      set { folderBrowseBox1.FolderPath = value; }
    }

    private void removeButton_Click(object sender, EventArgs e)
    {
      if (RemoveButtonClicked != null) RemoveButtonClicked(this);
    }
  }
}

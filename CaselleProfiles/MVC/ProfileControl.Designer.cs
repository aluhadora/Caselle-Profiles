using CaselleProfiles.MVC.ProfileDialog;

namespace CaselleProfiles.MVC
{
  partial class ProfileControl
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.labelPanel = new System.Windows.Forms.Panel();
      this.nameLabel = new System.Windows.Forms.Label();
      this.browePanel = new System.Windows.Forms.Panel();
      this.folderBrowseBox1 = new FolderBrowseBox();
      this.buttonPanel = new System.Windows.Forms.Panel();
      this.removeButton = new System.Windows.Forms.Button();
      this.labelPanel.SuspendLayout();
      this.browePanel.SuspendLayout();
      this.buttonPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // labelPanel
      // 
      this.labelPanel.BackColor = System.Drawing.SystemColors.Window;
      this.labelPanel.Controls.Add(this.nameLabel);
      this.labelPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.labelPanel.Location = new System.Drawing.Point(0, 0);
      this.labelPanel.Name = "labelPanel";
      this.labelPanel.Size = new System.Drawing.Size(95, 22);
      this.labelPanel.TabIndex = 0;
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.Location = new System.Drawing.Point(4, 4);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(82, 13);
      this.nameLabel.TabIndex = 2;
      this.nameLabel.Text = "Profile directory:";
      // 
      // browePanel
      // 
      this.browePanel.BackColor = System.Drawing.SystemColors.Window;
      this.browePanel.Controls.Add(this.folderBrowseBox1);
      this.browePanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.browePanel.Location = new System.Drawing.Point(95, 0);
      this.browePanel.Name = "browePanel";
      this.browePanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
      this.browePanel.Size = new System.Drawing.Size(279, 22);
      this.browePanel.TabIndex = 1;
      // 
      // folderBrowseBox1
      // 
      this.folderBrowseBox1.BackColor = System.Drawing.SystemColors.Window;
      this.folderBrowseBox1.DialogDescription = "";
      this.folderBrowseBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.folderBrowseBox1.FolderCreationAllowed = false;
      this.folderBrowseBox1.FolderPath = "";
      this.folderBrowseBox1.Location = new System.Drawing.Point(3, 0);
      this.folderBrowseBox1.Name = "folderBrowseBox1";
      this.folderBrowseBox1.NextFocusControl = null;
      this.folderBrowseBox1.Size = new System.Drawing.Size(273, 22);
      this.folderBrowseBox1.TabIndex = 0;
      this.folderBrowseBox1.TextBoxEditable = false;
      this.folderBrowseBox1.TextBoxWidth = 195;
      // 
      // buttonPanel
      // 
      this.buttonPanel.Controls.Add(this.removeButton);
      this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Right;
      this.buttonPanel.Location = new System.Drawing.Point(374, 0);
      this.buttonPanel.Name = "buttonPanel";
      this.buttonPanel.Size = new System.Drawing.Size(26, 22);
      this.buttonPanel.TabIndex = 2;
      // 
      // removeButton
      // 
      this.removeButton.BackColor = System.Drawing.SystemColors.Window;
      this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.removeButton.Location = new System.Drawing.Point(0, 0);
      this.removeButton.Name = "removeButton";
      this.removeButton.Size = new System.Drawing.Size(26, 22);
      this.removeButton.TabIndex = 0;
      this.removeButton.Text = "-";
      this.removeButton.UseVisualStyleBackColor = false;
      this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
      // 
      // ProfileControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.browePanel);
      this.Controls.Add(this.buttonPanel);
      this.Controls.Add(this.labelPanel);
      this.Name = "ProfileControl";
      this.Size = new System.Drawing.Size(400, 22);
      this.labelPanel.ResumeLayout(false);
      this.labelPanel.PerformLayout();
      this.browePanel.ResumeLayout(false);
      this.buttonPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel labelPanel;
    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.Panel browePanel;
    private FolderBrowseBox folderBrowseBox1;
    private System.Windows.Forms.Panel buttonPanel;
    private System.Windows.Forms.Button removeButton;
  }
}

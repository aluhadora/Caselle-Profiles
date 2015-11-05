namespace CaselleProfiles.MVC.ProfileDialog
{
  partial class ProfileDialog
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.okButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.addButton = new System.Windows.Forms.Button();
      this.profilePanel = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.profileButton = new System.Windows.Forms.Button();
      this.profilePanel.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // okButton
      // 
      this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.okButton.Location = new System.Drawing.Point(360, 16);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(75, 23);
      this.okButton.TabIndex = 7;
      this.okButton.Text = "OK";
      this.okButton.UseVisualStyleBackColor = true;
      this.okButton.Click += new System.EventHandler(this.OKClicked);
      // 
      // cancelButton
      // 
      this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.cancelButton.Location = new System.Drawing.Point(441, 16);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 23);
      this.cancelButton.TabIndex = 8;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.CancelClicked);
      // 
      // addButton
      // 
      this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.addButton.Location = new System.Drawing.Point(15, 15);
      this.addButton.Name = "addButton";
      this.addButton.Size = new System.Drawing.Size(28, 23);
      this.addButton.TabIndex = 10;
      this.addButton.Text = "+";
      this.addButton.UseVisualStyleBackColor = true;
      this.addButton.Click += new System.EventHandler(this.addButton_Click);
      // 
      // profilePanel
      // 
      this.profilePanel.Controls.Add(this.addButton);
      this.profilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.profilePanel.Location = new System.Drawing.Point(0, 0);
      this.profilePanel.Name = "profilePanel";
      this.profilePanel.Padding = new System.Windows.Forms.Padding(12);
      this.profilePanel.Size = new System.Drawing.Size(531, 431);
      this.profilePanel.TabIndex = 12;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.profileButton);
      this.panel2.Controls.Add(this.cancelButton);
      this.panel2.Controls.Add(this.okButton);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, 431);
      this.panel2.Name = "panel2";
      this.panel2.Padding = new System.Windows.Forms.Padding(12);
      this.panel2.Size = new System.Drawing.Size(531, 54);
      this.panel2.TabIndex = 13;
      // 
      // profileButton
      // 
      this.profileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.profileButton.Location = new System.Drawing.Point(15, 16);
      this.profileButton.Name = "profileButton";
      this.profileButton.Size = new System.Drawing.Size(120, 23);
      this.profileButton.TabIndex = 9;
      this.profileButton.Text = "Process from Tortoise HG";
      this.profileButton.UseVisualStyleBackColor = true;
      this.profileButton.Click += new System.EventHandler(this.BuildProfiles);
      // 
      // ProfileDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Window;
      this.ClientSize = new System.Drawing.Size(531, 485);
      this.Controls.Add(this.profilePanel);
      this.Controls.Add(this.panel2);
      this.MaximizeBox = false;
      this.MinimumSize = new System.Drawing.Size(447, 183);
      this.Name = "ProfileDialog";
      this.Text = "Profile Dialog";
      this.Load += new System.EventHandler(this.ProfileDialog_Load);
      this.profilePanel.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.Panel profilePanel;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button profileButton;
  }
}
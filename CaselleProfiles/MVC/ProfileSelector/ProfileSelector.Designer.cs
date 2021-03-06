﻿namespace CaselleProfiles.MVC.ProfileSelector
{
  partial class ProfileSelector
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileSelector));
      this.toolStrip = new System.Windows.Forms.ToolStrip();
      this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
      this.profileComboBox = new System.Windows.Forms.ToolStripComboBox();
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
      this.toolStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip
      // 
      this.toolStrip.BackColor = System.Drawing.SystemColors.Control;
      this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.profileComboBox,
            this.toolStripButton1});
      this.toolStrip.Location = new System.Drawing.Point(0, 0);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new System.Drawing.Size(521, 25);
      this.toolStrip.TabIndex = 1;
      this.toolStrip.Text = "toolStrip1";
      // 
      // toolStripLabel1
      // 
      this.toolStripLabel1.Name = "toolStripLabel1";
      this.toolStripLabel1.Size = new System.Drawing.Size(44, 22);
      this.toolStripLabel1.Text = "Profile:";
      // 
      // profileComboBox
      // 
      this.profileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.profileComboBox.Items.AddRange(new object[] {
            "Clarity 147",
            "2016.02",
            "Development"});
      this.profileComboBox.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
      this.profileComboBox.Name = "profileComboBox";
      this.profileComboBox.Size = new System.Drawing.Size(200, 25);
      this.profileComboBox.SelectedIndexChanged += new System.EventHandler(this.profileComboBox_SelectedIndexChanged);
      this.profileComboBox.Click += new System.EventHandler(this.profileComboBox_Click);
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton1.Text = "toolStripButton1";
      this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
      // 
      // ProfileSelector
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.toolStrip);
      this.Name = "ProfileSelector";
      this.Size = new System.Drawing.Size(521, 25);
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip;
    private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    private System.Windows.Forms.ToolStripComboBox profileComboBox;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
  }
}

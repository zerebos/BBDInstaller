namespace BandagedBD.Panels
{
    partial class UninstallConfigPanel
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
            this.userData = new BandagedBD.Controls.FlatCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbShouldRestart = new BandagedBD.Controls.FlatCheckBox();
            this.discordLocator = new BandagedBD.Controls.DiscordLocator();
            this.SuspendLayout();
            // 
            // userData
            // 
            this.userData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userData.AutoSize = true;
            this.userData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userData.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.userData.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.userData.Location = new System.Drawing.Point(9, 196);
            this.userData.Name = "userData";
            this.userData.Size = new System.Drawing.Size(170, 17);
            this.userData.TabIndex = 5;
            this.userData.Text = "Remove all BandagedBD data";
            this.userData.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.label1.Location = new System.Drawing.Point(6, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Additional Options:";
            // 
            // cbShouldRestart
            // 
            this.cbShouldRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbShouldRestart.AutoSize = true;
            this.cbShouldRestart.Checked = true;
            this.cbShouldRestart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShouldRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShouldRestart.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cbShouldRestart.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.cbShouldRestart.Location = new System.Drawing.Point(9, 219);
            this.cbShouldRestart.Name = "cbShouldRestart";
            this.cbShouldRestart.Size = new System.Drawing.Size(162, 17);
            this.cbShouldRestart.TabIndex = 34;
            this.cbShouldRestart.Text = "Restart All Discord Instances";
            this.cbShouldRestart.UseVisualStyleBackColor = true;
            // 
            // discordLocator
            // 
            this.discordLocator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.discordLocator.BackColor = System.Drawing.Color.Transparent;
            this.discordLocator.Location = new System.Drawing.Point(0, 3);
            this.discordLocator.Name = "discordLocator";
            this.discordLocator.Size = new System.Drawing.Size(662, 161);
            this.discordLocator.TabIndex = 6;
            // 
            // UninstallConfigPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cbShouldRestart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userData);
            this.Controls.Add(this.discordLocator);
            this.Name = "UninstallConfigPanel";
            this.Size = new System.Drawing.Size(662, 284);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BandagedBD.Controls.FlatCheckBox userData;
        private BandagedBD.Controls.DiscordLocator discordLocator;
        private System.Windows.Forms.Label label1;
        private BandagedBD.Controls.FlatCheckBox cbShouldRestart;
    }
}

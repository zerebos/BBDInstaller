namespace BandagedBD.Panels
{
    partial class RepairConfigPanel
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbBootLoop = new BandagedBD.Controls.FlatCheckBox();
            this.cbInfinite = new BandagedBD.Controls.FlatCheckBox();
            this.cbError = new BandagedBD.Controls.FlatCheckBox();
            this.cbUninjected = new BandagedBD.Controls.FlatCheckBox();
            this.discordLocator = new BandagedBD.Controls.DiscordLocator();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbShouldRestart = new BandagedBD.Controls.FlatCheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.label2.Location = new System.Drawing.Point(6, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Which of the following problems are affecting BandagedBD?";
            // 
            // cbBootLoop
            // 
            this.cbBootLoop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbBootLoop.AutoSize = true;
            this.cbBootLoop.BoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbBootLoop.BoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(130)))), ((int)(((byte)(229)))));
            this.cbBootLoop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbBootLoop.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.cbBootLoop.Location = new System.Drawing.Point(120, 265);
            this.cbBootLoop.Name = "cbBootLoop";
            this.cbBootLoop.Size = new System.Drawing.Size(121, 17);
            this.cbBootLoop.TabIndex = 26;
            this.cbBootLoop.Text = "Discord update loop";
            this.cbBootLoop.UseVisualStyleBackColor = true;
            // 
            // cbInfinite
            // 
            this.cbInfinite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbInfinite.AutoSize = true;
            this.cbInfinite.BoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbInfinite.BoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(130)))), ((int)(((byte)(229)))));
            this.cbInfinite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbInfinite.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.cbInfinite.Location = new System.Drawing.Point(120, 299);
            this.cbInfinite.Name = "cbInfinite";
            this.cbInfinite.Size = new System.Drawing.Size(167, 17);
            this.cbInfinite.TabIndex = 27;
            this.cbInfinite.Text = "BandagedBD loading infinitely";
            this.cbInfinite.UseVisualStyleBackColor = true;
            // 
            // cbError
            // 
            this.cbError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbError.AutoSize = true;
            this.cbError.BoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbError.BoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(130)))), ((int)(((byte)(229)))));
            this.cbError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbError.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.cbError.Location = new System.Drawing.Point(358, 299);
            this.cbError.Name = "cbError";
            this.cbError.Size = new System.Drawing.Size(176, 17);
            this.cbError.TabIndex = 28;
            this.cbError.Text = "Fatal JavaScript error on launch";
            this.cbError.UseVisualStyleBackColor = true;
            // 
            // cbUninjected
            // 
            this.cbUninjected.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbUninjected.AutoSize = true;
            this.cbUninjected.BoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbUninjected.BoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(130)))), ((int)(((byte)(229)))));
            this.cbUninjected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbUninjected.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.cbUninjected.Location = new System.Drawing.Point(358, 265);
            this.cbUninjected.Name = "cbUninjected";
            this.cbUninjected.Size = new System.Drawing.Size(218, 17);
            this.cbUninjected.TabIndex = 29;
            this.cbUninjected.Text = "BandagedBD not launching with Discord";
            this.cbUninjected.UseVisualStyleBackColor = true;
            // 
            // discordLocator
            // 
            this.discordLocator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discordLocator.BackColor = System.Drawing.Color.Transparent;
            this.discordLocator.Location = new System.Drawing.Point(0, 2);
            this.discordLocator.Name = "discordLocator";
            this.discordLocator.Size = new System.Drawing.Size(662, 202);
            this.discordLocator.TabIndex = 30;
            this.discordLocator.Load += new System.EventHandler(this.discordLocator_Load);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.label1.Location = new System.Drawing.Point(141, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Can\'t find your problem here?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = global::BandagedBD.Properties.Settings.Default.Accent;
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = global::BandagedBD.Properties.Settings.Default.Accent;
            this.linkLabel1.Location = new System.Drawing.Point(328, 334);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(114, 13);
            this.linkLabel1.TabIndex = 32;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Try this troubleshooter.";
            this.linkLabel1.VisitedLinkColor = global::BandagedBD.Properties.Settings.Default.Accent;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.label3.Location = new System.Drawing.Point(6, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Additional Options:";
            // 
            // cbShouldRestart
            // 
            this.cbShouldRestart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbShouldRestart.AutoSize = true;
            this.cbShouldRestart.BoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbShouldRestart.BoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(130)))), ((int)(((byte)(229)))));
            this.cbShouldRestart.Checked = true;
            this.cbShouldRestart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShouldRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShouldRestart.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cbShouldRestart.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.cbShouldRestart.Location = new System.Drawing.Point(120, 210);
            this.cbShouldRestart.Name = "cbShouldRestart";
            this.cbShouldRestart.Size = new System.Drawing.Size(162, 17);
            this.cbShouldRestart.TabIndex = 33;
            this.cbShouldRestart.Text = "Restart All Discord Instances";
            this.cbShouldRestart.UseVisualStyleBackColor = true;
            // 
            // RepairConfigPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbShouldRestart);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.discordLocator);
            this.Controls.Add(this.cbUninjected);
            this.Controls.Add(this.cbError);
            this.Controls.Add(this.cbInfinite);
            this.Controls.Add(this.cbBootLoop);
            this.Controls.Add(this.label2);
            this.Name = "RepairConfigPanel";
            this.Size = new System.Drawing.Size(662, 375);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private BandagedBD.Controls.FlatCheckBox cbBootLoop;
        private BandagedBD.Controls.FlatCheckBox cbInfinite;
        private BandagedBD.Controls.FlatCheckBox cbError;
        private BandagedBD.Controls.FlatCheckBox cbUninjected;
        private BandagedBD.Controls.DiscordLocator discordLocator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private BandagedBD.Controls.FlatCheckBox cbShouldRestart;
    }
}

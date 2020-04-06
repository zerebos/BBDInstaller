namespace BandagedBD.Controls {
    partial class DiscordLocator {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.titleLabel = new System.Windows.Forms.Label();
            this.browsePTB = new BandagedBD.Controls.Button();
            this.tbPTB = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.browseCanary = new BandagedBD.Controls.Button();
            this.tbCanary = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.browseStable = new BandagedBD.Controls.Button();
            this.tbStable = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.discordPTB = new BandagedBD.Controls.FlatCheckBox();
            this.discordCanary = new BandagedBD.Controls.FlatCheckBox();
            this.discordStable = new BandagedBD.Controls.FlatCheckBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.titleLabel.Location = new System.Drawing.Point(7, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(533, 13);
            this.titleLabel.TabIndex = 37;
            this.titleLabel.Text = "BandagedBD can attempt to fix several common problems. First we need to locate al" +
    "l BandagedBD installations:";
            // 
            // browsePTB
            // 
            this.browsePTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browsePTB.BackColor = global::BandagedBD.Properties.Settings.Default.Accent;
            this.browsePTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browsePTB.FlatAppearance.BorderSize = 0;
            this.browsePTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browsePTB.ForeColor = System.Drawing.Color.White;
            this.browsePTB.Location = new System.Drawing.Point(657, 138);
            this.browsePTB.Name = "browsePTB";
            this.browsePTB.Size = new System.Drawing.Size(86, 26);
            this.browsePTB.TabIndex = 36;
            this.browsePTB.Text = "Browse";
            this.browsePTB.UseVisualStyleBackColor = false;
            this.browsePTB.Click += new System.EventHandler(this.browsePTB_Click);
            // 
            // tbPTB
            // 
            this.tbPTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPTB.BackColor = global::BandagedBD.Properties.Settings.Default.SecondaryBackground;
            this.tbPTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbPTB.ForeColor = System.Drawing.Color.White;
            this.tbPTB.Location = new System.Drawing.Point(194, 143);
            this.tbPTB.Name = "tbPTB";
            this.tbPTB.ReadOnly = true;
            this.tbPTB.Size = new System.Drawing.Size(441, 15);
            this.tbPTB.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = global::BandagedBD.Properties.Settings.Default.SecondaryBackground;
            this.panel3.Location = new System.Drawing.Point(179, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 26);
            this.panel3.TabIndex = 35;
            // 
            // browseCanary
            // 
            this.browseCanary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseCanary.BackColor = global::BandagedBD.Properties.Settings.Default.Accent;
            this.browseCanary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseCanary.FlatAppearance.BorderSize = 0;
            this.browseCanary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseCanary.ForeColor = System.Drawing.Color.White;
            this.browseCanary.Location = new System.Drawing.Point(657, 89);
            this.browseCanary.Name = "browseCanary";
            this.browseCanary.Size = new System.Drawing.Size(86, 26);
            this.browseCanary.TabIndex = 33;
            this.browseCanary.Text = "Browse";
            this.browseCanary.UseVisualStyleBackColor = false;
            this.browseCanary.Click += new System.EventHandler(this.browseCanary_Click);
            // 
            // tbCanary
            // 
            this.tbCanary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCanary.BackColor = global::BandagedBD.Properties.Settings.Default.SecondaryBackground;
            this.tbCanary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCanary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbCanary.ForeColor = System.Drawing.Color.White;
            this.tbCanary.Location = new System.Drawing.Point(194, 95);
            this.tbCanary.Name = "tbCanary";
            this.tbCanary.ReadOnly = true;
            this.tbCanary.Size = new System.Drawing.Size(441, 15);
            this.tbCanary.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = global::BandagedBD.Properties.Settings.Default.SecondaryBackground;
            this.panel1.Location = new System.Drawing.Point(179, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 26);
            this.panel1.TabIndex = 32;
            // 
            // browseStable
            // 
            this.browseStable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseStable.BackColor = global::BandagedBD.Properties.Settings.Default.Accent;
            this.browseStable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseStable.FlatAppearance.BorderSize = 0;
            this.browseStable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseStable.ForeColor = System.Drawing.Color.White;
            this.browseStable.Location = new System.Drawing.Point(657, 42);
            this.browseStable.Name = "browseStable";
            this.browseStable.Size = new System.Drawing.Size(86, 26);
            this.browseStable.TabIndex = 30;
            this.browseStable.Text = "Browse";
            this.browseStable.UseVisualStyleBackColor = false;
            this.browseStable.Click += new System.EventHandler(this.browseStable_Click);
            // 
            // tbStable
            // 
            this.tbStable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStable.BackColor = global::BandagedBD.Properties.Settings.Default.SecondaryBackground;
            this.tbStable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbStable.ForeColor = System.Drawing.Color.White;
            this.tbStable.Location = new System.Drawing.Point(194, 48);
            this.tbStable.Name = "tbStable";
            this.tbStable.ReadOnly = true;
            this.tbStable.Size = new System.Drawing.Size(441, 15);
            this.tbStable.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = global::BandagedBD.Properties.Settings.Default.SecondaryBackground;
            this.panel2.Location = new System.Drawing.Point(179, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 26);
            this.panel2.TabIndex = 29;
            // 
            // discordPTB
            // 
            this.discordPTB.AutoSize = true;
            this.discordPTB.BoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.discordPTB.BoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(130)))), ((int)(((byte)(229)))));
            this.discordPTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discordPTB.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.discordPTB.Location = new System.Drawing.Point(10, 142);
            this.discordPTB.Name = "discordPTB";
            this.discordPTB.Size = new System.Drawing.Size(98, 17);
            this.discordPTB.TabIndex = 27;
            this.discordPTB.Text = "Repair On PTB";
            this.discordPTB.UseVisualStyleBackColor = true;
            this.discordPTB.CheckedChanged += new System.EventHandler(this.discordPTB_CheckedChanged);
            // 
            // discordCanary
            // 
            this.discordCanary.AutoSize = true;
            this.discordCanary.BoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.discordCanary.BoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(130)))), ((int)(((byte)(229)))));
            this.discordCanary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discordCanary.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.discordCanary.Location = new System.Drawing.Point(10, 94);
            this.discordCanary.Name = "discordCanary";
            this.discordCanary.Size = new System.Drawing.Size(110, 17);
            this.discordCanary.TabIndex = 26;
            this.discordCanary.Text = "Repair On Canary";
            this.discordCanary.UseVisualStyleBackColor = true;
            this.discordCanary.CheckedChanged += new System.EventHandler(this.discordCanary_CheckedChanged);
            // 
            // discordStable
            // 
            this.discordStable.AutoSize = true;
            this.discordStable.BoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.discordStable.BoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(130)))), ((int)(((byte)(229)))));
            this.discordStable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discordStable.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.discordStable.Location = new System.Drawing.Point(10, 47);
            this.discordStable.Name = "discordStable";
            this.discordStable.Size = new System.Drawing.Size(107, 17);
            this.discordStable.TabIndex = 25;
            this.discordStable.Text = "Repair On Stable";
            this.discordStable.UseVisualStyleBackColor = true;
            this.discordStable.CheckedChanged += new System.EventHandler(this.discordStable_CheckedChanged);
            // 
            // DiscordLocator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(110F, 110F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.browsePTB);
            this.Controls.Add(this.tbPTB);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.browseCanary);
            this.Controls.Add(this.tbCanary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.browseStable);
            this.Controls.Add(this.tbStable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.discordPTB);
            this.Controls.Add(this.discordCanary);
            this.Controls.Add(this.discordStable);
            this.Name = "DiscordLocator";
            this.Size = new System.Drawing.Size(759, 184);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.Button browsePTB;
        private System.Windows.Forms.TextBox tbPTB;
        private System.Windows.Forms.Panel panel3;
        private Controls.Button browseCanary;
        private System.Windows.Forms.TextBox tbCanary;
        private System.Windows.Forms.Panel panel1;
        private Controls.Button browseStable;
        private System.Windows.Forms.TextBox tbStable;
        private System.Windows.Forms.Panel panel2;
        private BandagedBD.Controls.FlatCheckBox discordPTB;
        private BandagedBD.Controls.FlatCheckBox discordCanary;
        private BandagedBD.Controls.FlatCheckBox discordStable;
        private System.Windows.Forms.Label titleLabel;
    }
}

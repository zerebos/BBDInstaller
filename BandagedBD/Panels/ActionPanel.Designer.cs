namespace BandagedBD.Panels
{
    partial class ActionPanel
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
            this.installButton = new System.Windows.Forms.Button();
            this.repairButton = new System.Windows.Forms.Button();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // installButton
            // 
            this.installButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.installButton.BackColor = global::BandagedBD.Properties.Settings.Default.Accent;
            this.installButton.BackgroundImage = global::BandagedBD.Properties.Resources.archive_small;
            this.installButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.installButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.installButton.FlatAppearance.BorderSize = 0;
            this.installButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installButton.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.installButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.installButton.Location = new System.Drawing.Point(29, 17);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(56, 56);
            this.installButton.TabIndex = 0;
            this.installButton.UseVisualStyleBackColor = false;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // repairButton
            // 
            this.repairButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.repairButton.BackColor = global::BandagedBD.Properties.Settings.Default.Accent;
            this.repairButton.BackgroundImage = global::BandagedBD.Properties.Resources.build_small;
            this.repairButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.repairButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.repairButton.FlatAppearance.BorderSize = 0;
            this.repairButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repairButton.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.repairButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.repairButton.Location = new System.Drawing.Point(29, 123);
            this.repairButton.Name = "repairButton";
            this.repairButton.Size = new System.Drawing.Size(56, 56);
            this.repairButton.TabIndex = 1;
            this.repairButton.UseVisualStyleBackColor = false;
            this.repairButton.Click += new System.EventHandler(this.repairButton_Click);
            // 
            // uninstallButton
            // 
            this.uninstallButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uninstallButton.BackColor = global::BandagedBD.Properties.Settings.Default.Accent;
            this.uninstallButton.BackgroundImage = global::BandagedBD.Properties.Resources.delete_small;
            this.uninstallButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uninstallButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uninstallButton.FlatAppearance.BorderSize = 0;
            this.uninstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uninstallButton.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.uninstallButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uninstallButton.Location = new System.Drawing.Point(29, 231);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(56, 56);
            this.uninstallButton.TabIndex = 2;
            this.uninstallButton.UseVisualStyleBackColor = false;
            this.uninstallButton.Click += new System.EventHandler(this.uninstallButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.label1.Location = new System.Drawing.Point(102, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Install BandagedBD";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.label2.Location = new System.Drawing.Point(102, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Repair BandagedBD";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.label3.Location = new System.Drawing.Point(102, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uninstall BandagedBD";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.label4.Location = new System.Drawing.Point(102, 39);
            this.label4.MaximumSize = new System.Drawing.Size(450, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(434, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "This allows you to install BandagedBD to your existing Discord installation. Band" +
    "agedBD is able to install to Discord Stable, Discord Canary, and Discord PTB sep" +
    "arately.";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.label5.Location = new System.Drawing.Point(102, 145);
            this.label5.MaximumSize = new System.Drawing.Size(450, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(447, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "This repairs an existing BandagedBD installation fixing multiple issues. This inc" +
    "ludes but is not limited to a broken injection, corrupt data files, and Discord " +
    "update loops.";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.label6.Location = new System.Drawing.Point(102, 253);
            this.label6.MaximumSize = new System.Drawing.Size(450, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(450, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "This option fully removes BandagedBD from a Discord installation and optionally c" +
    "leans up any user data related to BandagedBD.";
            // 
            // ActionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::BandagedBD.Properties.Settings.Default.PrimaryBackground;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uninstallButton);
            this.Controls.Add(this.repairButton);
            this.Controls.Add(this.installButton);
            this.Name = "ActionPanel";
            this.Size = new System.Drawing.Size(580, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Button repairButton;
        private System.Windows.Forms.Button uninstallButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

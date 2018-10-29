namespace BandagedBD.Panels {
    partial class InstallPanel {
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
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.cbDetailed = new BandagedBD.Controls.FlatCheckBox();
            this.rtbDetailed = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbStatus = new BandagedBD.Controls.FlatProgressBar();
            this.SuspendLayout();
            // 
            // rtbStatus
            // 
            this.rtbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbStatus.BackColor = global::BandagedBD.Properties.Settings.Default.SecondaryBackground;
            this.rtbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbStatus.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.rtbStatus.Location = new System.Drawing.Point(13, 8);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.ReadOnly = true;
            this.rtbStatus.Size = new System.Drawing.Size(474, 113);
            this.rtbStatus.TabIndex = 0;
            this.rtbStatus.Text = "";
            // 
            // cbDetailed
            // 
            this.cbDetailed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDetailed.AutoSize = true;
            this.cbDetailed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDetailed.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.cbDetailed.Location = new System.Drawing.Point(4, 138);
            this.cbDetailed.Name = "cbDetailed";
            this.cbDetailed.Size = new System.Drawing.Size(58, 17);
            this.cbDetailed.TabIndex = 2;
            this.cbDetailed.Text = "Details";
            this.cbDetailed.UseVisualStyleBackColor = true;
            this.cbDetailed.CheckedChanged += new System.EventHandler(this.cbDetailed_CheckedChanged);
            // 
            // rtbDetailed
            // 
            this.rtbDetailed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDetailed.BackColor = global::BandagedBD.Properties.Settings.Default.SecondaryBackground;
            this.rtbDetailed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDetailed.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.rtbDetailed.Location = new System.Drawing.Point(13, 8);
            this.rtbDetailed.Name = "rtbDetailed";
            this.rtbDetailed.ReadOnly = true;
            this.rtbDetailed.Size = new System.Drawing.Size(474, 113);
            this.rtbDetailed.TabIndex = 3;
            this.rtbDetailed.Text = "";
            this.rtbDetailed.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = global::BandagedBD.Properties.Settings.Default.SecondaryBackground;
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 129);
            this.panel1.TabIndex = 4;
            // 
            // pbStatus
            // 
            this.pbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbStatus.BackColor = global::BandagedBD.Properties.Settings.Default.SecondaryBackground;
            this.pbStatus.ForeColor = global::BandagedBD.Properties.Settings.Default.Accent;
            this.pbStatus.Location = new System.Drawing.Point(67, 135);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(428, 23);
            this.pbStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbStatus.TabIndex = 7;
            // 
            // InstallPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.cbDetailed);
            this.Controls.Add(this.rtbStatus);
            this.Controls.Add(this.rtbDetailed);
            this.Controls.Add(this.panel1);
            this.Name = "InstallPanel";
            this.Size = new System.Drawing.Size(501, 166);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbStatus;
        private BandagedBD.Controls.FlatCheckBox cbDetailed;
        private System.Windows.Forms.RichTextBox rtbDetailed;
        private System.Windows.Forms.Panel panel1;
        private Controls.FlatProgressBar pbStatus;
    }
}

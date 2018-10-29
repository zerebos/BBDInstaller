namespace BandagedBD.Panels
{
    partial class UninstallPanel
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
            this.richText = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbStatus = new BandagedBD.Controls.FlatProgressBar();
            this.SuspendLayout();
            // 
            // richText
            // 
            this.richText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richText.BackColor = global::BandagedBD.Properties.Settings.Default.SecondaryBackground;
            this.richText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richText.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.richText.Location = new System.Drawing.Point(13, 8);
            this.richText.Name = "richText";
            this.richText.ReadOnly = true;
            this.richText.Size = new System.Drawing.Size(474, 113);
            this.richText.TabIndex = 0;
            this.richText.Text = "";
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
            this.pbStatus.Location = new System.Drawing.Point(4, 135);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(491, 23);
            this.pbStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbStatus.TabIndex = 6;
            // 
            // UninstallPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.panel1);
            this.Name = "UninstallPanel";
            this.Size = new System.Drawing.Size(501, 166);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.Panel panel1;
        private Controls.FlatProgressBar pbStatus;
    }
}

using System.Drawing;

namespace BandagedBD {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private readonly Pen headerPen = new Pen(Color.FromArgb(32, 32, 32));
        private readonly SolidBrush headerBrush = new SolidBrush(Properties.Settings.Default.SecondaryBackground);
        private Rectangle headerShape => new Rectangle(0, 0, Width, 85);

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                headerBrush.Dispose();
                headerPen.Dispose();
                if (components != null) components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelDock = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new BandagedBD.Controls.Button();
            this.btnNext = new BandagedBD.Controls.Button();
            this.btnBack = new BandagedBD.Controls.Button();
            this.SuspendLayout();
            // 
            // panelDock
            // 
            this.panelDock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDock.AutoScroll = true;
            this.panelDock.AutoScrollMinSize = new System.Drawing.Size(700, 300);
            this.panelDock.BackColor = System.Drawing.Color.Transparent;
            this.panelDock.Location = new System.Drawing.Point(12, 96);
            this.panelDock.Name = "panelDock";
            this.panelDock.Size = new System.Drawing.Size(752, 339);
            this.panelDock.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(82, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(145, 16);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "BandagedBD Setup";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::BandagedBD.Properties.Resources.BBDVS;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(64, 64);
            this.logo.TabIndex = 4;
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
            this.linkLabel1.Location = new System.Drawing.Point(132, 471);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 13);
            this.linkLabel1.TabIndex = 34;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Consider donating.";
            this.linkLabel1.VisitedLinkColor = global::BandagedBD.Properties.Settings.Default.Accent;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.label1.Location = new System.Drawing.Point(13, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Enjoying BandagedBD?";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = global::BandagedBD.Properties.Settings.Default.Accent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.btnCancel.Location = new System.Drawing.Point(689, 466);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = global::BandagedBD.Properties.Settings.Default.Accent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.btnNext.Location = new System.Drawing.Point(608, 466);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = global::BandagedBD.Properties.Settings.Default.Accent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = global::BandagedBD.Properties.Settings.Default.TextColor;
            this.btnBack.Location = new System.Drawing.Point(527, 466);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = global::BandagedBD.Properties.Settings.Default.PrimaryBackground;
            this.ClientSize = new System.Drawing.Size(776, 501);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.panelDock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BandagedBD Installer v0.3.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDock;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Label lblTitle;
        public Controls.Button btnNext;
        public Controls.Button btnCancel;
        public Controls.Button btnBack;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}


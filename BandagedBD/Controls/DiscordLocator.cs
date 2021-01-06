using System;
using System.Windows.Forms;

namespace BandagedBD.Controls {
    public partial class DiscordLocator : UserControl {

        public bool stable => discordStable.Checked;
        public bool canary => discordCanary.Checked;
        public bool ptb => discordPTB.Checked;
        public bool development => discordDevelopment.Checked;

        public EventHandler OnCheckedChange;

        public DiscordLocator() {
            InitializeComponent();
            if (Utilities.CurrentStablePath != null) tbStable.Text = Utilities.CurrentStablePath;
            if (Utilities.CurrentCanaryPath != null) tbCanary.Text = Utilities.CurrentCanaryPath;
            if (Utilities.CurrentPtbPath != null) tbPTB.Text = Utilities.CurrentPtbPath;
            if (Utilities.CurrentDevelopmentPath != null) tbDevelopment.Text = Utilities.CurrentDevelopmentPath;
            Utilities.EnsureDiscord(tbStable, discordStable, Discord.Stable);
            Utilities.EnsureDiscord(tbCanary, discordCanary, Discord.Canary);
            Utilities.EnsureDiscord(tbPTB, discordPTB, Discord.PTB);
            Utilities.EnsureDiscord(tbDevelopment, discordDevelopment, Discord.Development);
        }

        public void setLabel(string label) {
            titleLabel.Text = label;
        }

        public void setCheckboxLabel(Discord which, string label) {
            if (which == Discord.Stable) discordStable.Text = label;
            if (which == Discord.Canary) discordCanary.Text = label;
            if (which == Discord.PTB) discordPTB.Text = label;
            if (which == Discord.Development) discordDevelopment.Text = label;
        }

        private void browseStable_Click(object sender, EventArgs e) {
            var fbd = new FolderBrowserDialog { SelectedPath = tbStable.Text };
            fbd.ShowDialog();
            tbStable.Text = fbd.SelectedPath;
            Utilities.EnsureDiscord(tbStable, discordStable, Discord.Stable);
        }

        private void browseCanary_Click(object sender, EventArgs e) {
            var fbd = new FolderBrowserDialog { SelectedPath = tbCanary.Text };
            fbd.ShowDialog();
            tbCanary.Text = fbd.SelectedPath;
            Utilities.EnsureDiscord(tbCanary, discordCanary, Discord.Canary);
        }

        private void browsePTB_Click(object sender, EventArgs e) {
            var fbd = new FolderBrowserDialog { SelectedPath = tbPTB.Text };
            fbd.ShowDialog();
            tbPTB.Text = fbd.SelectedPath;
            Utilities.EnsureDiscord(tbPTB, discordPTB, Discord.PTB);
        }

        private void browseDevelopment_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog { SelectedPath = tbDevelopment.Text };
            fbd.ShowDialog();
            tbDevelopment.Text = fbd.SelectedPath;
            Utilities.EnsureDiscord(tbDevelopment, discordDevelopment, Discord.Development);
        }

        private void discordStable_CheckedChanged(object sender, EventArgs e) {
            if (discordStable.Checked) Utilities.EnsureDiscord(tbStable, discordStable, Discord.Stable);
            OnCheckedChange?.Invoke(sender, e);
        }

        private void discordCanary_CheckedChanged(object sender, EventArgs e) {
            if (discordCanary.Checked) Utilities.EnsureDiscord(tbCanary, discordCanary, Discord.Canary);
            OnCheckedChange?.Invoke(sender, e);
        }

        private void discordPTB_CheckedChanged(object sender, EventArgs e) {
            if (discordPTB.Checked) Utilities.EnsureDiscord(tbPTB, discordPTB, Discord.PTB);
            OnCheckedChange?.Invoke(sender, e);
        }

        private void discordDevelopment_CheckedChanged(object sender, EventArgs e)
        {
            if (discordDevelopment.Checked) Utilities.EnsureDiscord(tbDevelopment, discordDevelopment, Discord.Development);
            OnCheckedChange?.Invoke(sender, e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BandagedBD.Panels {
    public partial class UninstallConfigPanel : UserControl, IPanel {

        private FormMain Window;
        public void SetWindow(FormMain formMain) => Window = formMain;

        public string Title => "Uninstall Setup";
        public UserControl Control => this;

        public PanelTypes PreviousPanel => PanelTypes.Action;
        public PanelTypes NextPanel => PanelTypes.Uninstall;

        public string[] pathsToDelete {
            get {
                List<string> paths = new List<string>(Utilities.GetLocalPaths(discordLocator.stable, discordLocator.canary, discordLocator.ptb, discordLocator.development, "resources\\app"));
                if (userData.Checked) paths.Add($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\BetterDiscord");
                return paths.ToArray();
            }
        }
        public string[] executables => Utilities.GetExecutables(discordLocator.stable, discordLocator.canary, discordLocator.ptb, discordLocator.development);
        public bool shouldRestart => cbShouldRestart.Checked;

        public UninstallConfigPanel() {
            InitializeComponent();
            discordLocator.setLabel("BandagedBD will be removed from the locations below. Click browse if the locations are incorrect.");
            discordLocator.setCheckboxLabel(Discord.Stable, "Remove from Stable");
            discordLocator.setCheckboxLabel(Discord.Canary, "Remove from Canary");
            discordLocator.setCheckboxLabel(Discord.PTB, "Remove from PTB");
            discordLocator.setCheckboxLabel(Discord.Development, "Remove from Development");
            discordLocator.OnCheckedChange += OnCheckedChange;
        }

        public void OnShow() {
            Window.btnBack.ShowEnable();
            Window.btnCancel.ShowEnable("Cancel");
            Window.btnNext.ShowDisable("Uninstall");
        }

        private void OnCheckedChange(object sender, EventArgs e) {
            if (discordLocator.stable || discordLocator.canary || discordLocator.ptb || discordLocator.development) Window.btnNext.ShowEnable("Uninstall");
            else Window.btnNext.ShowDisable("Uninstall");
        }

    }
}

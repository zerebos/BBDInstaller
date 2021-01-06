using System;
using System.Windows.Forms;

namespace BandagedBD.Panels {
    public partial class RepairConfigPanel : UserControl, IPanel {

        private FormMain Window;
        public void SetWindow(FormMain formMain) => Window = formMain;

        public PanelTypes PreviousPanel => PanelTypes.Action;
        public PanelTypes NextPanel => PanelTypes.Repair;

        public string Title => "Repair Setup";
        public UserControl Control => this;

        public string[] localPaths => Utilities.GetLocalPaths(discordLocator.stable, discordLocator.canary, discordLocator.ptb, discordLocator.development, "resources\\app");
        public string[] roamingPaths => Utilities.GetRoamingPaths(discordLocator.stable, discordLocator.canary, discordLocator.ptb, discordLocator.development);
        public string[] executables => Utilities.GetExecutables(discordLocator.stable, discordLocator.canary, discordLocator.ptb, discordLocator.development);

        public bool shouldDeleteRoaming => cbError.Checked || cbBootLoop.Checked;
        public bool shouldDeleteLocal => cbBootLoop.Checked;
        public bool shouldDeleteStorage => cbInfinite.Checked;
        public bool shouldReinstall => cbUninjected.Checked || cbBootLoop.Checked;
        public bool shouldRestart => cbShouldRestart.Checked;

        public RepairConfigPanel() {
            InitializeComponent();
            discordLocator.setLabel("BandagedBD can attempt to fix several common problems. First we need to locate all BandagedBD installations:");
            discordLocator.setCheckboxLabel(Discord.Stable, "Repair On Stable");
            discordLocator.setCheckboxLabel(Discord.Canary, "Repair On Canary");
            discordLocator.setCheckboxLabel(Discord.PTB, "Repair On PTB");
            discordLocator.setCheckboxLabel(Discord.Development, "Repair On Development");
            discordLocator.OnCheckedChange += OnCheckedChange;
            cbError.CheckedChanged += OnCheckedChange;
            cbBootLoop.CheckedChanged += OnCheckedChange;
            cbUninjected.CheckedChanged += OnCheckedChange;
            cbInfinite.CheckedChanged += OnCheckedChange;
        }

        public void OnShow() {
            Window.btnBack.ShowEnable();
            Window.btnCancel.ShowEnable("Cancel");
            Window.btnNext.ShowDisable("Repair");
        }

        private void OnCheckedChange(object sender, EventArgs e) {
            bool location = discordLocator.stable || discordLocator.canary || discordLocator.ptb || discordLocator.development;
            bool problem = cbError.Checked || cbBootLoop.Checked || cbUninjected.Checked || cbInfinite.Checked;
            if (location && problem) Window.btnNext.ShowEnable("Repair");
            else Window.btnNext.ShowDisable("Repair");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Utilities.OpenProcess("https://0x71.cc/bd/troubleshoot/");
        }

        private void discordLocator_Load(object sender, EventArgs e)
        {

        }
    }
}

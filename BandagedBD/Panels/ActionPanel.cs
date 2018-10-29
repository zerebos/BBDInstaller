using System;
using System.Windows.Forms;

namespace BandagedBD.Panels {
    public partial class ActionPanel : UserControl, IPanel {
        private FormMain Window;
        public void SetWindow(FormMain window) => Window = window;

        public string Title => "Choose an Action";
        public UserControl Control => this;

        public PanelTypes PreviousPanel => PanelTypes.License;
        public PanelTypes NextPanel => _nextPanel;
        private PanelTypes _nextPanel = PanelTypes.Install;

        public ActionPanel() {
            InitializeComponent();
        }

        public void OnShow() {
            Window.btnBack.ShowEnable();
            Window.btnCancel.ShowEnable("Cancel");
            Window.btnNext.HideDisable();
            Show();
        }

        private void GoToNext(PanelTypes next) {
            _nextPanel = next;
            Window.btnNext.ShowEnable("");
            Window.btnNext.PerformClick();
        }

        private void installButton_Click(object sender, EventArgs e) {
            GoToNext(PanelTypes.InstallConfig);
        }

        private void repairButton_Click(object sender, EventArgs e) {
            GoToNext(PanelTypes.RepairConfig);
        }

        private void uninstallButton_Click(object sender, EventArgs e) {
            GoToNext(PanelTypes.UninstallConfig);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BandagedBD.Panels {
    public partial class UninstallPanel : UserControl, IPanel {

        private FormMain Window;
        public void SetWindow(FormMain formMain) => Window = formMain;

        public string Title => "Uninstalling";
        public UserControl Control => this;

        public PanelTypes PreviousPanel => PanelTypes.InstallConfig;
        public PanelTypes NextPanel => PanelTypes.NONE;

        private UninstallConfigPanel Config => (UninstallConfigPanel) Window.GetPanel(PanelTypes.UninstallConfig);

        public UninstallPanel() {
            InitializeComponent();
        }

        private void Uninstall() {
            List<string> exes = new List<string>();
            foreach (var process in Config.executables) exes.Add(Utilities.KillProcess(process, Append));
            pbStatus.Value = 20;
            string[] paths = Config.pathsToDelete;
            int chunk = 80 / paths.Length;
            int i = 0;
            Utilities.DeleteFolders(paths, (message) => {
                Append(message);
                pbStatus.Value = (chunk * i + chunk) + 20;
                i++;
            });
            foreach (var exe in exes) {
                if (exe != string.Empty && Config.shouldRestart) Utilities.OpenProcess(exe);
            }
            Append("Uninstalling Complete!");
        }

        public void OnShow() {
            richText.Text = "";
            Uninstall();
            Window.btnCancel.ShowEnable("Exit");
        }

        private void Append(string text) {
            richText.AppendText(text);
            richText.AppendText(Environment.NewLine);
            richText.ScrollToCaret();
        }
    }
}

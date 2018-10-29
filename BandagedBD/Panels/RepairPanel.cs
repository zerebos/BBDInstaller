using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace BandagedBD.Panels {
    public partial class RepairPanel : UserControl, IPanel {

        private FormMain Window;
        public void SetWindow(FormMain formMain) => Window = formMain;

        public string Title => "Repairing";
        public UserControl Control => this;

        public PanelTypes PreviousPanel => PanelTypes.InstallConfig;
        public PanelTypes NextPanel => Config.shouldReinstall ? PanelTypes.InstallConfig : PanelTypes.NONE;

        private RepairConfigPanel Config => (RepairConfigPanel) Window.GetPanel(PanelTypes.RepairConfig);

        public RepairPanel() {
            InitializeComponent();
        }

        private void Repair() {
            List<string> exes = new List<string>();
            foreach (var process in Config.executables) exes.Add(Utilities.KillProcess(process, Append));
            pbStatus.Value = 25;
            if (Config.shouldDeleteRoaming) Utilities.DeleteFolders(Config.roamingPaths, Append);
            pbStatus.Value = 50;
            if (Config.shouldDeleteLocal) Utilities.DeleteFolders(Config.localPaths, Append);
            pbStatus.Value = 75;
            if (Config.shouldDeleteStorage) Utilities.DeleteFiles(new string[] { $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\BetterDiscord\\bdstorage.json" }, Append);
            pbStatus.Value = 100;
            if (Config.shouldReinstall) {
                Append("In order to complete repairs, BandagedBD needs to be reinstalled. Click Install to continue.");
                Window.btnNext.ShowEnable("Install");
                var confirmResult = MessageBox.Show("In order to complete repairs, BandagedBD needs to be reinstalled. Reinstall now?", "Reinstall needed!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes) Window.btnNext.PerformClick();
                else {
                    Window.btnNext.HideDisable();
                    Window.btnBack.HideDisable();
                    Window.btnCancel.ShowEnable("Exit");
                }
            }
            else {
                foreach (var exe in exes) {
                    if (exe != string.Empty && Config.shouldRestart) Utilities.OpenProcess(exe);
                }
                Append("Repairs completed!");
            }

        }

        public void OnShow() {
            richText.Text = "";
            if (Config.shouldReinstall) Window.btnNext.HideDisable("Install");
            Repair();
        }

        private void Append(string text) {
            Debug.WriteLine(text);
            richText.AppendText(text);
            richText.AppendText(Environment.NewLine);
            richText.ScrollToCaret();
        }
    }
}

using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BandagedBD.Panels {
    public partial class InstallPanel : UserControl, IPanel {
        private FormMain Window;
        public void SetWindow(FormMain formMain) => Window = formMain;

        public string Title => "Installing";
        public UserControl Control => this;

        public PanelTypes PreviousPanel => PanelTypes.InstallConfig;
        public PanelTypes NextPanel => PanelTypes.NONE;

        private InstallConfigPanel config => (InstallConfigPanel) Window.GetPanel(PanelTypes.InstallConfig);

        private readonly SynchronizationContext _synchronizationContext;
        private int progressChunk => 100 / config.paths.Length;
        private int iteration = 0;

        private string repo = "rauenzi";
        private string branch = "injector";

        public InstallPanel() {
            InitializeComponent();
            _synchronizationContext = SynchronizationContext.Current;
        }

        private void setProgress(int baseAmount) {
            _synchronizationContext.Post(_ => {
                pbStatus.Value = ((baseAmount * progressChunk) / 100) + (progressChunk * iteration);
            }, 100);
        }

        private async Task<int> InstallTask() {
            string[] processNames = config.executables;
            string[] paths = config.paths;
            for (int i = 0; i < paths.Length; i++) {
                iteration = i;
                Append($"Starting installation for {processNames[i]}");
                Append($"Killing {processNames[i]} Processes");
                string currentExecutable = Utilities.KillProcess(processNames[i], Append);

                if (await DownloadBd(paths[i]) != 1) {
                    setProgress(0);
                    Append("Download seems to have failed, will try once more.");
                    if (await DownloadBd(paths[i]) != 1) return 0;
                }
                
                setProgress(75);
                if (Verify(paths[i]) != 1) return 0;
                setProgress(90);
                if (config.shouldRestart && currentExecutable != string.Empty) {
                    Append($"Restarting {processNames[i]}");
                    Utilities.OpenProcess(currentExecutable);
                }
                setProgress(100);
                Append($"Finished installing BandagedBD for {processNames[i]}!");
                Append("---------------------------------------------------------------------------------");
            }
            return 1;
        }

        private async Task<int> DownloadBd(string installationPath) {
            var channel = $"https://github.com/{repo}/BetterDiscordApp/archive/{branch}.zip";
            var dest = $"{installationPath}\\resources\\BetterDiscord.zip";

            Append("Downloading BandagedBD package");

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;


            using (var wc = new TimedWebClient()) {
                wc.DownloadProgressChanged += (sender, args) => {
                    setProgress(args.ProgressPercentage / 2);
                };

                Append($"Using channel: {channel}", true);
                Append($"Downloading to: {dest}", true);

                try {
                    await wc.DownloadFileTaskAsync(channel, dest);
                }
                catch (WebException e) {
                    Append("Download error: " + e.Message, true);
                    return 0;
                }

            }

            Append("Finished downloading BandagedBD package");

            return ExtractBd(dest, $"{installationPath}\\resources");
        }

        private int ExtractBd(string path, string dest) {

            if (Directory.Exists($"{dest}\\app")) {
                Append("Deleting old BetterDiscord");
                Directory.Delete($"{dest}\\app", true);
            }

            if (Directory.Exists($"{dest}\\BetterDiscordApp-{branch}")) {
                Append($"Deleting old BetterDiscordApp-{branch}");
                Directory.Delete($"{dest}\\BetterDiscordApp-{branch}", true);
            }

            Append("Extracting BandagedBD package");

            if (!File.Exists(path)) {
                Append($"BandagedBD package does not exist in: {path}. Cannot continue.");
                return 0;
            }

            var zar = ZipFile.OpenRead(path);

            if (!Directory.Exists(dest)) {
                Directory.CreateDirectory(dest);
            }

            zar.ExtractToDirectory(dest);
            zar.Dispose();
            if (!Directory.Exists($"{dest}\\BetterDiscordApp-{branch}")) {
                Append($"BandagedBD package does not exist in: {dest}\\BetterDiscordApp-{branch}. Cannot continue.");
                return 0;
            }

            Append("Renaming package dir");

            Directory.Move($"{dest}\\BetterDiscordApp-{branch}", $"{dest}\\app");

            if (File.Exists(path)) {
                Append($"Deleting temp file {path}");
                File.Delete(path);
            }

            return 1;
        }

        private int Verify(string installationPath) {

            Append("Verifying installation");
            Append("Checking for old style injection");
            foreach (var roaming in config.roamings) {
                var core = $"{roaming}\\modules\\discord_desktop_core\\core";
                Append($"Checking for old injection {roaming}", true);
                if (!Directory.Exists(core)) continue;
                Append($"Deleting old injection {roaming}", true);
                try {
                    Directory.Delete(roaming, true);
                }
                catch {
                    Append($"Please delete this folder: {roaming}");
                }
            }

            var appFolder = $"{installationPath}\\resources\\app";
            if (!Directory.Exists(appFolder)) {
                Append($"{appFolder} does not exist! Verification failed!");
                Window.Fail();
                return 0;
            }

            var injectorFiles = new[] { "index.js", "config.json", "package.json", "betterdiscord\\index.js", "betterdiscord\\config.json", "betterdiscord\\utils.js" };

            foreach (var bdFile in injectorFiles) {
                if (File.Exists($"{appFolder}\\{bdFile}")) {
                    Append($"Verifying {appFolder}\\{bdFile}", true);
                    continue;
                }
                Append($"{appFolder}\\{bdFile} does not exist! Verification failed!");
                Window.Fail();
                return 0;
            }

            Append("Verification successful");

            return 1;
        }

        public void OnShow() {
            rtbStatus.Text = "";
            Task.Run(InstallTask).ContinueWith(result => {
                if (result.Result == 0) Window.Fail();
                _synchronizationContext.Post(o => {
                    Window.btnCancel.ShowEnable("Exit");
                }, result);
            });

        }

        private void Append(string text, bool detailed = false) {
            _synchronizationContext.Post(o => {
                if (!detailed) {
                    rtbStatus.AppendText((string) o);
                    rtbStatus.AppendText(Environment.NewLine);
                }
                rtbDetailed.AppendText((string) o);
                rtbDetailed.AppendText(Environment.NewLine);
                rtbStatus.ScrollToCaret();
                rtbDetailed.ScrollToCaret();
            }, text);
        }

        private void cbDetailed_CheckedChanged(object sender, EventArgs e) {
            rtbDetailed.Visible = cbDetailed.Checked;
            rtbStatus.Visible = !cbDetailed.Checked;
        }
    }
}
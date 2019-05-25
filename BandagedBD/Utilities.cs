using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BandagedBD {

    public enum Discord { Stable, Canary, PTB };

    public class Utilities {
        public static readonly Regex _matcher = new Regex(@"[0-9]+\.[0-9]+\.[0-9]+");
        public static string StablePath => $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\Discord";
        public static bool StableExists() => Directory.Exists(StablePath);
        public static string CanaryPath => $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\DiscordCanary";
        public static bool CanaryExists() => Directory.Exists(CanaryPath);
        public static string PtbPath => $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\DiscordPTB";
        public static bool PtbExists() => Directory.Exists(PtbPath);

        public static string CurrentStablePath = StableExists() ? StablePath : null;
        public static string CurrentCanaryPath = CanaryExists() ? CanaryPath : null;
        public static string CurrentPtbPath = PtbExists() ? PtbPath : null;

        public static void OpenProcess(string url) {
            Process.Start(url);
        }

        public static void DeleteFolders(string[] paths, Action<string> onMessage = null) {
            for (int i = 0; i < paths.Length; i++) {
                onMessage?.Invoke($"Deleting {paths[i]}");
                if (!Directory.Exists(paths[i])) {
                    onMessage?.Invoke($"{paths[i]} does not exist, skipping.");
                    continue;
                }
                try {
                    Directory.Delete(paths[i], true);
                }
                catch {
                    onMessage?.Invoke($"Could not delete {paths[i]} please delete manually.");
                }
            }
        }

        public static void DeleteFiles(string[] paths, Action<string> onMessage = null) {
            for (int i = 0; i < paths.Length; i++) {
                onMessage?.Invoke($"Deleting {paths[i]}");
                try {
                    File.Delete(paths[i]);
                }
                catch {
                    onMessage?.Invoke($"Could not delete {paths[i]} please delete manually.");
                }
            }
        }

        public static string KillProcess(string processName, Action<string> onMessage = null) {
            return KillProcess(processName, (str, boolean) => {
                onMessage?.Invoke(str);
            });
        }

        public static string KillProcess(string processName, Action<string, bool> onMessage = null) {
            var currentExecutable = string.Empty;
            try {
                foreach (var process in Process.GetProcessesByName(processName)) {
                    onMessage?.Invoke($"Killing {processName} process {process.Id}", true);
                    currentExecutable = process.MainModule.FileName;
                    process.Kill();
                }
            }
            catch { }
            return currentExecutable;
        }

        public static string[] GetExecutables(bool stable, bool canary, bool ptb) {
            List<string> exes = new List<string>();
            if (stable) exes.Add("Discord");
            if (canary) exes.Add("DiscordCanary");
            if (ptb) exes.Add("DiscordPTB");
            return exes.ToArray();
        }

        public static string[] GetRoamingPaths(bool stable, bool canary, bool ptb, string subFolder = "") {
            List<string> roaming = new List<string>();
            var stableFolder = GetRoaming("discord");
            var canaryFolder = GetRoaming("discordcanary");
            var ptbFolder = GetRoaming("discordptb");
            if (stable && stableFolder != string.Empty) roaming.Add($"{stableFolder}\\{subFolder}");
            if (canary && canaryFolder != string.Empty) roaming.Add($"{canaryFolder}\\{subFolder}");
            if (ptb && ptbFolder != string.Empty) roaming.Add($"{ptbFolder}\\{subFolder}");
            return roaming.ToArray();
        }

        public static string[] GetLocalPaths(bool stable, bool canary, bool ptb, string subFolder = "") {
            List<string> paths = new List<string>();
            if (stable) paths.Add($"{CurrentStablePath}\\{subFolder}");
            if (canary) paths.Add($"{CurrentCanaryPath}\\{subFolder}");
            if (ptb) paths.Add($"{CurrentPtbPath}\\{subFolder}");
            return paths.ToArray();
        }

        public static string GetExe(Discord which) {
            if (which == Discord.Stable) return "Discord";
            if (which == Discord.Canary) return "DiscordCanary";
            if (which == Discord.PTB) return "DiscordPTB";
            return "";
        }

        public static void EnsureDiscord(TextBox tb, CheckBox cb, Discord which) {
            if (tb.Text.ToLower().Contains("could not find")) {
                cb.Checked = false;
                return;
            }
            
            var baseFolder = GetLatestVersion(tb.Text);
            if (baseFolder == string.Empty) baseFolder = tb.Text;
            string executable = GetExe(which);
            tb.ForeColor = Properties.Settings.Default.TextColor;
            if (!File.Exists(baseFolder + $"\\{executable}.exe")) {
                tb.Text = $"Could not find {executable}.exe!";
                tb.ForeColor = Color.Red;
                cb.Checked = false;
            }
            else {
                tb.Text = baseFolder;
                if (which == Discord.Stable) CurrentStablePath = baseFolder;
                if (which == Discord.Canary) CurrentCanaryPath = baseFolder;
                if (which == Discord.PTB) CurrentPtbPath = baseFolder;
            }
        }

        public static string GetLatestVersion(string path) {
            if (path == string.Empty) return path;
            if (!Directory.Exists(path)) return string.Empty;
            var dirs = Directory.GetDirectories(path);
            if (dirs.Length <= 0) return string.Empty;
            var latest = Path.GetFileName(dirs[0]);

            foreach (var dir in dirs) {
                if (!_matcher.IsMatch(Path.GetFileName(dir))) continue;
                if (string.CompareOrdinal(Path.GetFileName(dir), latest) > 0) latest = Path.GetFileName(dir);
            }

            return _matcher.IsMatch(latest) ? Path.Combine(path, latest) : string.Empty;
        }

        public static string GetRoaming(string version) {
            return GetLatestVersion($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{version}");
        }
    }
}

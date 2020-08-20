using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace BandagedBD.Silent {
    class SilentOnlyUtilities {
        private bool useStable;
        private bool useCanary;
        private bool usePTB;

        // Additional Options
        private bool shouldRestart = true;

        // Repair Options
        public bool shouldDeleteRoaming;
        public bool shouldDeleteLocal;
        public bool shouldDeleteStorage;
        public bool shouldReinstall;

        // Uninstall Options
        public bool shouldDeleteUserData;

        // General
        private string repo = "rauenzi";
        private string branch = "injector";

        private int iteration = 0;

        private string[] processNames;
        private string[] paths;
        private string[] roamings;

        private int progressChunk;

        public string[] pathsToDelete {
            get {
                List<string> paths = new List<string>(Utilities.GetLocalPaths(useStable, useCanary, usePTB, "resources\\app"));
                if (shouldDeleteUserData) paths.Add($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\BetterDiscord");
                return paths.ToArray();
            }
        }

        public SilentOnlyUtilities(LaunchMode launchMode, string[] args) {
            processArgs(args);

            if (useStable || useCanary || usePTB) {
                paths = Utilities.GetLocalPaths(useStable, useCanary, usePTB);
                processNames = Utilities.GetExecutables(useStable, useCanary, usePTB);
                roamings = Utilities.GetRoamingPaths(useStable, useCanary, usePTB);

                if (paths.Length > 0) progressChunk = 100 / paths.Length;

                switch (launchMode) {
                    case LaunchMode.Install:
                        Install();
                        break;
                    case LaunchMode.Repair:
                        Repair();
                        break;
                    case LaunchMode.Uninstall:
                        Uninstall();
                        break;
                }
            } else {
                Console.WriteLine("No branch specified, please use -stable, -canary or -ptb");
            }
        }

        private void setProgress(int baseAmount) {
            Console.WriteLine(((baseAmount * progressChunk) / 100) + (progressChunk * iteration) + "% of 100% complete");
        }

        private void processArgs(string[] args) {
            for (int i = 0; i < args.Length; i++) {
                switch (args[i].ToLower()) {
                    // Path switches
                    // If Path switch is found then next argument should be the path
                    case "-stablepath":
                    case "-stable":
                        useStable = true;
                        Utilities.CurrentStablePath = args[i + 1];
                        i++;
                        break;
                    case "-canarypath":
                    case "-canary":
                        useCanary = true;
                        Utilities.CurrentCanaryPath = args[i + 1];
                        i++;
                        break;
                    case "-ptbpath":
                    case "-ptb":
                        usePTB = true;
                        Utilities.CurrentPtbPath = args[i + 1];
                        i++;
                        break;

                    // Additional Options switches
                    case "-norestart":
                        shouldRestart = false;
                        break;

                    // Repair switches
                    case "-repairupdateloop":
                        shouldDeleteRoaming = true;
                        shouldDeleteLocal = true;
                        shouldReinstall = true;
                        break;
                    case "-repairnotlaunching":
                        shouldReinstall = true;
                        break;
                    case "-repairloadingindefinitely":
                        shouldDeleteStorage = true;
                        break;
                    case "-repairjavascripterror":
                        shouldDeleteRoaming = true;
                        break;
                    case "-deleteuserdata":
                        shouldDeleteUserData = true;
                        break;
                }
            }
        }

        private void Install() {
            InstallTask();
        }

        private void Repair() {
            List<string> exes = new List<string>();
            foreach (var process in processNames) exes.Add(Utilities.KillProcess(process, Append));
            if (shouldDeleteRoaming) Utilities.DeleteFolders(Utilities.GetRoamingPaths(useStable, useCanary, usePTB), Append);
            if (shouldDeleteLocal) Utilities.DeleteFolders(Utilities.GetLocalPaths(useStable, useCanary, usePTB), Append);
            if (shouldDeleteStorage) Utilities.DeleteFiles(new string[] { $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\BetterDiscord\\bdstorage.json" }, Append);
            if (shouldReinstall) {
                Install();
            } else {
                foreach (var exe in exes) {
                    if (exe != string.Empty && shouldRestart) Utilities.OpenProcess(exe);
                }
                Append("Repairs completed!");
            }
        }

        private void Uninstall() {
            List<string> exes = new List<string>();
            foreach (var process in processNames) exes.Add(Utilities.KillProcess(process, Append));
            string[] deletePaths = pathsToDelete;
            int chunk = 80 / deletePaths.Length;
            int i = 0;
            int newValue = 20;
            Utilities.DeleteFolders(deletePaths, (message) => {
                Append(message);
                newValue = (chunk * i + chunk) + 20;
                i++;
            });
            foreach (var exe in exes) {
                if (exe != string.Empty && shouldRestart) Utilities.OpenProcess(exe);
            }
            Append("Uninstalling Complete!");
        }

        private int InstallTask() {
            for (int i = 0; i < paths.Length; i++) {
                iteration = i;
                Append($"Starting installation for {processNames[i]}");
                Append($"Killing {processNames[i]} Processes");
                string currentExecutable = Utilities.KillProcess(processNames[i], Append);

                if (DownloadBd(paths[i]) != 1) {
                    setProgress(0);
                    Append("Download seems to have failed, will try once more.");
                    if (DownloadBd(paths[i]) != 1) return 0;
                }

                setProgress(75);
                if (Verify(paths[i]) != 1) return 0;
                setProgress(90);
                if (shouldRestart && currentExecutable != string.Empty) {
                    Append($"Restarting {processNames[i]}");
                    Utilities.OpenProcess(currentExecutable);
                }
                setProgress(100);
                Append($"Finished installing BandagedBD for {processNames[i]}!");
                Append("---------------------------------------------------------------------------------");
            }
            return 1;
        }

        private int DownloadBd(string installationPath) {
            var channel = $"https://github.com/{repo}/BetterDiscordApp/archive/{branch}.zip";
            var dest = $"{installationPath}\\resources\\BetterDiscord.zip";

            Append("Downloading BandagedBD package");

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;


            using (var wc = new TimedWebClient()) {
                wc.DownloadProgressChanged += (sender, args) => {
                    setProgress(args.ProgressPercentage / 2);
                };

                Append($"Using channel: {channel}");
                Append($"Downloading to: {dest}");

                try {
                    wc.DownloadFile(channel, dest);
                } catch (WebException e) {
                    Append("Download error: " + e.Message);
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
            foreach (var roaming in roamings) {
                var core = $"{roaming}\\modules\\discord_desktop_core\\core";
                Append($"Checking for old injection {roaming}");
                if (!Directory.Exists(core)) continue;
                Append($"Deleting old injection {roaming}");
                try {
                    Directory.Delete(roaming, true);
                } catch {
                    Append($"Please delete this folder: {roaming}");
                }
            }

            var appFolder = $"{installationPath}\\resources\\app";
            if (!Directory.Exists(appFolder)) {
                Append($"{appFolder} does not exist! Verification failed!");
                return 0;
            }

            var injectorFiles = new[] { "index.js", "package.json", "betterdiscord\\index.js", "betterdiscord\\preload.js", "betterdiscord\\config.json", "betterdiscord\\logger.js" };

            foreach (var bdFile in injectorFiles) {
                if (File.Exists($"{appFolder}\\{bdFile}")) {
                    Append($"Verifying {appFolder}\\{bdFile}");
                    continue;
                }
                Append($"{appFolder}\\{bdFile} does not exist! Verification failed!");
                return 0;
            }

            Append("Verification successful");

            return 1;
        }

        private void Append(string text) {
            Console.WriteLine(text);
        }
    }
}

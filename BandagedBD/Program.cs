using BandagedBD.Silent;
using System;
using System.Windows.Forms;

namespace BandagedBD {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main(string[] args) {
            LaunchMode launchMode = LaunchMode.GUI;

            // check first argument to check if it is a silent install switch
            switch (args[0].ToLower()) {
                // Silent Install switches
                case "-install":
                case "-i":
                    launchMode = LaunchMode.Install;
                    break;
                case "-repair":
                case "-r":
                    launchMode = LaunchMode.Repair;
                    break;
                case "-uninstall":
                case "-u":
                    launchMode = LaunchMode.Uninstall;
                    break;
                case "-help":
                case "-h":
                    launchMode = LaunchMode.None;
                    Console.WriteLine("-install, -i   Install BBD\n" +
                        "-uninstall, -u   Uninstall BBD\n" +
                        "   Optional switches for uninstall\n" +
                        "      -deleteuserdata   deletes all user settings of betterdiscord\n" +
                        "-repair, -r   Repair BBD\n" +
                        "   Optional switches for repair, for the following issues\n" +
                        "      -repairupdateloop   Discord update loop\n" +
                        "      -repairnotlaunching   BandagedBD not launching with Discord\n" +
                        "      -repairloadingindefinitely   BandagedBD loading indefinitely\n" +
                        "      -repairjavascripterror   Fatal JavaScript error on launch\n" +
                        "\nall require using one or more of the following\n" +
                        "   -stable [path], -canary [path], -ptb [path]\n" +
                        "\n-norestart   By default discord will be restarted, this disables restarting of processes" +
                        "");
                    break;
                default:
                    break;
            }

            switch (launchMode) {
                case LaunchMode.GUI:
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FormMain());
                    break;
                case LaunchMode.None:
                    break;
                default:
                    new SilentOnlyUtilities(launchMode, args);
                    break;
            }
        } 
    }
}

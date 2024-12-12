using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace UltraEditAutomation.Common
{
    [TestModule("2F917574-72A0-4ADE-A96E-BD153C793AB2", ModuleType.UserCode, 1)]
    public class RestoreDefaultSettings : ITestModule
    {
        public RestoreDefaultSettings() { }

        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            var appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var sourceFolder = @"C:\UltraEditDefaultSettings\UltraEdit";
            var destinationFolder = Path.Combine(appdata, "IDMComp\\UltraEdit");

            try
            {
            	List<string> processList = new List<string> { "uedit64" }; 
       		         KillRunningProcesses.KillProcesses(processList);
       		         
                if (Directory.Exists(destinationFolder))
                { 
                    // Ensure the folder is not in use and If it exists, delete it first (to replace it)
                    Report.Info("Deleting existing destination folder...");
                    Directory.Delete(destinationFolder, true);
                    Report.Info("Folder deleted successfully.");
                }
                // Now copy the source folder to the destination
                Report.Info("Copying source folder to destination...");
                CopyDirectory(sourceFolder, destinationFolder);
                Report.Success("Settings restored successfully.");
            }
            catch (UnauthorizedAccessException ex)
            {
                Report.Error($"Access denied: {ex.Message}");
                throw;
            }
            catch (IOException ex)
            {
                Report.Error($"IO error: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Report.Error($"An unexpected error occurred: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Copies a directory and its contents to a destination.
        /// </summary>
        /// <param name="sourceDir">The source directory path.</param>
        /// <param name="destinationDir">The destination directory path.</param>
        private static void CopyDirectory(string sourceDir, string destinationDir)
        {
            Directory.CreateDirectory(destinationDir);

            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string destFile = Path.Combine(destinationDir, Path.GetFileName(file));
                File.Copy(file, destFile, true);
            }

            foreach (string subdir in Directory.GetDirectories(sourceDir))
            {
                string destSubDir = Path.Combine(destinationDir, Path.GetFileName(subdir));
                CopyDirectory(subdir, destSubDir);
            }
        }
    }
}

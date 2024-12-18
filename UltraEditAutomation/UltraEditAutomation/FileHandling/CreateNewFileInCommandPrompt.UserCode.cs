using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;


namespace UltraEditAutomation.FileHandling
{
    public partial class CreateNewFileInCommandPrompt
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void CommandPrompt()
        {
            try
            {
                // Step 1: Start Command Prompt with appropriate settings
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
				FileName = "cmd.exe",    // Path to Command Prompt executable
                Arguments = "/K uedit64 C:\\temp\\newfile.txt",          // Optional arguments
                WorkingDirectory = @"C:\Windows\System32", // Optional starting directory
                UseShellExecute = true,  // Required for administrative privileges
                Verb = "runas"

                };

                // Step 2: Launch Command Prompt
                Process cmdProcess = Process.Start(processInfo);
                Report.Success("Command Prompt opened successfully.");
                Thread.Sleep(2000);
 
                //Step 3: Wait for the process to complete
                cmdProcess.WaitForExit();
                 
                Report.Success("newfile.txt created successfully.");
            }
            catch (Exception ex)
            {
                // Log error in case of failure
                Report.Error("Error while automating Command Prompt: " + ex.Message);
            }
        }
    }
}

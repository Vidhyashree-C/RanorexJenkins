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
                    FileName = "cmd.exe", // Path to Command Prompt executable
                    Arguments = "/K uedit64 C:\\temp\\newfile.txt", // Use /K to run the command and exit
                    WorkingDirectory = @"C:\Windows\System32", // Optional starting directory
                    UseShellExecute = false,  // Allow interaction via StandardInput
                    RedirectStandardInput = true, // Redirect standard input
                    RedirectStandardOutput = true, // Capture output (optional)
                    RedirectStandardError = true, // Capture errors
                    CreateNoWindow = false // Show the Command Prompt window
                };

                // Step 2: Launch Command Prompt
                Process cmdProcess = Process.Start(processInfo);
                
                // Log success message
                Report.Info("Command Prompt opened successfully.");

                // Step 3: Wait for the process to complete
                //cmdProcess.WaitForExit();

                // Log the result
                Report.Info("Command executed successfully: uedit64 C:\\temp\\newfile.txt");
            }
            catch (Exception ex)
            {
                // Log error in case of failure
                Report.Error("Error while automating Command Prompt: " + ex.Message);
            }
        }
    }
}

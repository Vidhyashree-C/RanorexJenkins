/*
 * Created by Ranorex
 * User: vidhyashree.c
 * Date: 11/27/2024
 * Time: 06:25 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace UltraEditAutomation
{
    /// <summary>
    /// Description of FileDeletion.
    /// </summary>
    [TestModule("11AE5738-4113-49FF-8DA3-50CD33535578", ModuleType.UserCode, 1)]
    public class FileDeletion : ITestModule
    {
        // Define the file paths as parameters so they can be reused in different test cases
        [TestVariable("file_to_delete1")]
        public string FileToDelete1 { get; set; } 

        [TestVariable("file_to_delete2")]
        public string FileToDelete2 { get; set; }

    	
        public FileDeletion()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
       
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            // Call the method to delete files
            DeleteFile(FileToDelete1);
            DeleteFile(FileToDelete2);
        }
        
        private void DeleteFile(string filePath)
        {
            try
            {
            	if (string.IsNullOrEmpty(filePath))
                {
                   return; // Do nothing for empty or null paths
                }
            	
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    Report.Success($"File '{filePath}' deleted successfully.");
                }
                else
                {
                    Report.Warn($"File '{filePath}' not found.");
                }
            }
            catch (Exception ex)
            {
                Report.Error($"Error deleting file '{filePath}': {ex.Message}");
            }
        }
    }
}

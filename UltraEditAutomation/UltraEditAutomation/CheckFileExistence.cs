/*
 * Created by Ranorex
 * User: vidhyashree.c
 * Date: 11/27/2024
 * Time: 07:24 PM
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
    /// Description of CheckFileExistence.
    /// </summary>
    [TestModule("3E1B288D-ADDE-48CB-B0D6-84B6F2E70E14", ModuleType.UserCode, 1)]
    public class CheckFileExistence : ITestModule
    {
        [TestVariable("source_file1")]
        public string SourceFile1 { get; set; }
        
        [TestVariable("source_file2")]
        public string SourceFile2 { get; set; }
        
        
        public CheckFileExistence()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            CheckFile(SourceFile1);
            CheckFile(SourceFile2);
        }
        private void CheckFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    Report.Success($"File '{filePath}' exists.");
                }
                else
                {
                    Report.Info($"File '{filePath}' does not exist.");
                }
            }
            catch (Exception ex)
            {
                Report.Error($"Error while checking file existence: {ex.Message}");
            }
            
    }
}
}

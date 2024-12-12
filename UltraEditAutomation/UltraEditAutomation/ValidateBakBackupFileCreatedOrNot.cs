/*
 * Created by Ranorex
 * User: celestial
 * Date: 01-12-2024
 * Time: 22:40
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using System.IO;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace UltraEditAutomation
{
    /// <summary>
    /// Description of ValidateBakBackupFileCreatedOrNot.
    /// </summary>
    [TestModule("9883C95C-FED6-4D71-8D54-3078246B4284", ModuleType.UserCode, 1)]
    public class ValidateBakBackupFileCreatedOrNot : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateBakBackupFileCreatedOrNot()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [TestVariable("SourceFile")]
        public string SourceFile { get; set; }
        
     
        
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            CheckFile(SourceFile);
            Delay.Seconds(2);
            
        }

		 private void CheckFile(string FilePath)
        {
            try
            {
            	
                if (File.Exists(FilePath))
                {
                    Report.Success($"File '{FilePath}' exists.");
                }
                else
                {
                    Report.Failure($"File '{FilePath}' does not exist.");
                }
            }
            catch (Exception ex)
            {
                Report.Error($"Error while checking file existence: {ex.Message}");
            }

		 }



    }
}

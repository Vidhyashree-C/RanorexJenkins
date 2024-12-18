﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace UltraEditAutomation.FileHandling
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CreateNewFileInCommandPrompt recording.
    /// </summary>
    [TestModule("2c83e4bd-d1d8-4250-991d-6ed73cb9fdde", ModuleType.Recording, 1)]
    public partial class CreateNewFileInCommandPrompt : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::UltraEditAutomation.UltraEditAutomationRepository repository.
        /// </summary>
        public static global::UltraEditAutomation.UltraEditAutomationRepository repo = global::UltraEditAutomation.UltraEditAutomationRepository.Instance;

        static CreateNewFileInCommandPrompt instance = new CreateNewFileInCommandPrompt();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateNewFileInCommandPrompt()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateNewFileInCommandPrompt Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Windows\\System32\\cmd.exe' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("C:\\Windows\\System32\\cmd.exe", "", "", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to exist. Associated repository item: 'AdministratorCmd'", repo.AdministratorCmd.SelfInfo, new ActionTimeout(15000), new RecordItemIndex(1));
            repo.AdministratorCmd.SelfInfo.WaitForExists(15000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'uedit64 C:\\temp\\newfile.txt' with focus on 'AdministratorCmd'.", repo.AdministratorCmd.SelfInfo, new RecordItemIndex(2));
            repo.AdministratorCmd.Self.PressKeys("uedit64 C:\\temp\\newfile.txt");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'AdministratorCmd'.", repo.AdministratorCmd.SelfInfo, new RecordItemIndex(3));
            repo.AdministratorCmd.Self.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

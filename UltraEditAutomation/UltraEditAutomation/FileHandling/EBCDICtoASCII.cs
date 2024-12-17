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
    ///The EBCDICtoASCII recording.
    /// </summary>
    [TestModule("cf658415-57a9-4c67-9c94-50349029e570", ModuleType.Recording, 1)]
    public partial class EBCDICtoASCII : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::UltraEditAutomation.UltraEditAutomationRepository repository.
        /// </summary>
        public static global::UltraEditAutomation.UltraEditAutomationRepository repo = global::UltraEditAutomation.UltraEditAutomationRepository.Instance;

        static EBCDICtoASCII instance = new EBCDICtoASCII();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EBCDICtoASCII()
        {
            File = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EBCDICtoASCII Instance
        {
            get { return instance; }
        }

#region Variables

        string _File;

        /// <summary>
        /// Gets or sets the value of variable File.
        /// </summary>
        [TestVariable("25d7fffa-b6bd-4132-9ea7-56b4bbf1a28e")]
        public string File
        {
            get { return _File; }
            set { _File = value; }
        }

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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'UltraEdit64Bit.ToolBar.Advanced'.", repo.UltraEdit64Bit.ToolBar.AdvancedInfo, new RecordItemIndex(0));
            repo.UltraEdit64Bit.ToolBar.Advanced.Select();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCUltraEditFilesUe20241025T06120.Conversions' at 90;9.", repo.FormCUltraEditFilesUe20241025T06120.ConversionsInfo, new RecordItemIndex(1));
            repo.FormCUltraEditFilesUe20241025T06120.Conversions.Click("90;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.EBCDICToASCII' at 89;10.", repo.Uedit64.EBCDICToASCIIInfo, new RecordItemIndex(2));
            repo.Uedit64.EBCDICToASCII.Click("89;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Title='ASCII2EBCDIC.txt*') on item 'FormEdit1UltraEdit64Bit.ASCII2EBCDICTxtAsterisk'.", repo.FormEdit1UltraEdit64Bit.ASCII2EBCDICTxtAsteriskInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FormEdit1UltraEdit64Bit.ASCII2EBCDICTxtAsteriskInfo, "Title", "ASCII2EBCDIC.txt*");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "File is changed", repo.FormEdit1UltraEdit64Bit.ASCII2EBCDICTxtAsterisk, false, new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1252  (ANSI - Latin I)') on item 'FormCUltraEditFilesUe20241025T06120.Text1252ANSILatinI'.", repo.FormCUltraEditFilesUe20241025T06120.Text1252ANSILatinIInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FormCUltraEditFilesUe20241025T06120.Text1252ANSILatinIInfo, "Text", "1252  (ANSI - Latin I)");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.FormCUltraEditFilesUe20241025T06120.Text1252ANSILatinI, false, new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.ApplicationMenu' at 29;12.", repo.Uedit64.ApplicationMenuInfo, new RecordItemIndex(7));
            repo.Uedit64.ApplicationMenu.Click("29;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.SaveAs' at Center.", repo.Uedit64.SaveAsInfo, new RecordItemIndex(8));
            repo.Uedit64.SaveAs.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$File' with focus on 'SaveAs.Text1001'.", repo.SaveAs.Text1001Info, new RecordItemIndex(9));
            repo.SaveAs.Text1001.PressKeys(File);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SaveAs.ButtonSave' at 22;17.", repo.SaveAs.ButtonSaveInfo, new RecordItemIndex(10));
            repo.SaveAs.ButtonSave.Click("22;17");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

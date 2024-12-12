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

namespace UltraEditAutomation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Delete_BeginingofTheWord recording.
    /// </summary>
    [TestModule("30592967-c650-4a79-9a04-973ba9ba242b", ModuleType.Recording, 1)]
    public partial class Delete_BeginingofTheWord : ITestModule
    {
        /// <summary>
        /// Holds an instance of the UltraEditAutomationRepository repository.
        /// </summary>
        public static UltraEditAutomationRepository repo = UltraEditAutomationRepository.Instance;

        static Delete_BeginingofTheWord instance = new Delete_BeginingofTheWord();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Delete_BeginingofTheWord()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Delete_BeginingofTheWord Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'UltraEdit64Bit.Home'.", repo.UltraEdit64Bit.HomeInfo, new RecordItemIndex(0));
            repo.UltraEdit64Bit.Home.Select();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.Goto' at 23;23.", repo.Uedit64.GotoInfo, new RecordItemIndex(1));
            repo.Uedit64.Goto.Click("23;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoTo.RadioButtonLineColumn' at 23;12.", repo.GoTo.RadioButtonLineColumnInfo, new RecordItemIndex(2));
            repo.GoTo.RadioButtonLineColumn.Click("23;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '4/1' with focus on 'GoTo'.", repo.GoTo.SelfInfo, new RecordItemIndex(3));
            repo.GoTo.Self.EnsureVisible();
            Keyboard.Press("4/1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoTo.Goto' at 60;17.", repo.GoTo.GotoInfo, new RecordItemIndex(4));
            repo.GoTo.Goto.Click("60;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+Back' Press with focus on 'Uedit64'.", repo.Uedit64.SelfInfo, new RecordItemIndex(5));
            Keyboard.PrepareFocus(repo.Uedit64.Self);
            Keyboard.Press(System.Windows.Forms.Keys.Back | System.Windows.Forms.Keys.Control, 14, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'UltraEdit64Bit.editorScreen'.", repo.UltraEdit64Bit.editorScreenInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.UltraEdit64Bit.editorScreenInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            retriveSpecificLine();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.Goto' at 18;21.", repo.Uedit64.GotoInfo, new RecordItemIndex(8));
            repo.Uedit64.Goto.Click("18;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoTo.RadioButtonLineColumn' at 60;9.", repo.GoTo.RadioButtonLineColumnInfo, new RecordItemIndex(9));
            repo.GoTo.RadioButtonLineColumn.Click("60;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '5/14' with focus on 'GoTo'.", repo.GoTo.SelfInfo, new RecordItemIndex(10));
            repo.GoTo.Self.EnsureVisible();
            Keyboard.Press("5/14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoTo.Goto' at 64;11.", repo.GoTo.GotoInfo, new RecordItemIndex(11));
            repo.GoTo.Goto.Click("64;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'Uedit64.Edit'.", repo.Uedit64.EditInfo, new RecordItemIndex(12));
            repo.Uedit64.Edit.Select();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.Select' at 20;52.", repo.Uedit64.SelectInfo, new RecordItemIndex(13));
            repo.Uedit64.Select.Click("20;52");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.SelectWord' at 80;9.", repo.Uedit64.SelectWordInfo, new RecordItemIndex(14));
            repo.Uedit64.SelectWord.Click("80;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.Delete' at 22;54.", repo.Uedit64.DeleteInfo, new RecordItemIndex(15));
            repo.Uedit64.Delete.Click("22;54");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.Delete1' at 72;11.", repo.Uedit64.Delete1Info, new RecordItemIndex(16));
            repo.Uedit64.Delete1.Click("72;11");
            Delay.Milliseconds(0);
            
            verifyLine();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='changes.txt*') on item 'FormEdit1UltraEdit64Bit.PageTabList'.", repo.FormEdit1UltraEdit64Bit.PageTabListInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.FormEdit1UltraEdit64Bit.PageTabListInfo, "AccessibleValue", "changes.txt*");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

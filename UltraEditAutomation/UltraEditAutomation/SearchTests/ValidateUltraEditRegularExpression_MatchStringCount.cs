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

namespace UltraEditAutomation.SearchTests
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidateUltraEditRegularExpression_MatchStringCount recording.
    /// </summary>
    [TestModule("df9b4d3f-127f-4e4d-9916-6b04b2aaf3b0", ModuleType.Recording, 1)]
    public partial class ValidateUltraEditRegularExpression_MatchStringCount : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::UltraEditAutomation.UltraEditAutomationRepository repository.
        /// </summary>
        public static global::UltraEditAutomation.UltraEditAutomationRepository repo = global::UltraEditAutomation.UltraEditAutomationRepository.Instance;

        static ValidateUltraEditRegularExpression_MatchStringCount instance = new ValidateUltraEditRegularExpression_MatchStringCount();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateUltraEditRegularExpression_MatchStringCount()
        {
            Text = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateUltraEditRegularExpression_MatchStringCount Instance
        {
            get { return instance; }
        }

#region Variables

        string _Text;

        /// <summary>
        /// Gets or sets the value of variable Text.
        /// </summary>
        [TestVariable("c12f1358-4a82-447f-a479-d6df21291b7e")]
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.Uedit64.FindTextField' at 75;13.", repo.FindAndReplace.Uedit64.FindTextFieldInfo, new RecordItemIndex(0));
            repo.FindAndReplace.Uedit64.FindTextField.Click("75;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'FindAndReplace.Uedit64.FindTextField'.", repo.FindAndReplace.Uedit64.FindTextFieldInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.FindAndReplace.Uedit64.FindTextField);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Text' with focus on 'FindAndReplace.Uedit64.FindTextField'.", repo.FindAndReplace.Uedit64.FindTextFieldInfo, new RecordItemIndex(2));
            repo.FindAndReplace.Uedit64.FindTextField.PressKeys(Text);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.Uedit64.GearButton' at 16;11.", repo.FindAndReplace.Uedit64.GearButtonInfo, new RecordItemIndex(3));
            repo.FindAndReplace.Uedit64.GearButton.Click("16;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.Uedit64.RegularExpressions' at 12;8.", repo.FindAndReplace.Uedit64.RegularExpressionsInfo, new RecordItemIndex(4));
            repo.FindAndReplace.Uedit64.RegularExpressions.Click("12;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FindAndReplace.Uedit64.RegularExpressions'.", repo.FindAndReplace.Uedit64.RegularExpressionsInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FindAndReplace.Uedit64.RegularExpressionsInfo, "Checked", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Regular &expressions:') on item 'FindAndReplace.Uedit64.RegularExpressions'.", repo.FindAndReplace.Uedit64.RegularExpressionsInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FindAndReplace.Uedit64.RegularExpressionsInfo, "Text", "Regular &expressions:");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.Uedit64.ComboBox2926' at 78;4.", repo.FindAndReplace.Uedit64.ComboBox2926Info, new RecordItemIndex(7));
            repo.FindAndReplace.Uedit64.ComboBox2926.Click("78;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.UltraEdit' at 67;9.", repo.List1000.UltraEditInfo, new RecordItemIndex(8));
            repo.List1000.UltraEdit.Click("67;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (SelectedItemText='UltraEdit') on item 'FindAndReplace.Uedit64.ComboBox2926'.", repo.FindAndReplace.Uedit64.ComboBox2926Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FindAndReplace.Uedit64.ComboBox2926Info, "SelectedItemText", "UltraEdit");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.Uedit64.CheckBoxCloseAfterFind' at 10;3.", repo.FindAndReplace.Uedit64.CheckBoxCloseAfterFindInfo, new RecordItemIndex(10));
            repo.FindAndReplace.Uedit64.CheckBoxCloseAfterFind.Click("10;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'FindAndReplace.Uedit64.CheckBoxCloseAfterFind'.", repo.FindAndReplace.Uedit64.CheckBoxCloseAfterFindInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FindAndReplace.Uedit64.CheckBoxCloseAfterFindInfo, "Checked", "False");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.Uedit64.ButtonNext' at 46;8.", repo.FindAndReplace.Uedit64.ButtonNextInfo, new RecordItemIndex(12));
            repo.FindAndReplace.Uedit64.ButtonNext.Click("46;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.Uedit64.CountAll' at 20;7.", repo.FindAndReplace.Uedit64.CountAllInfo, new RecordItemIndex(13));
            repo.FindAndReplace.Uedit64.CountAll.Click("20;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='27 occurrences found.') on item 'FindAndReplace.Uedit64.occurrences'.", repo.FindAndReplace.Uedit64.occurrencesInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FindAndReplace.Uedit64.occurrencesInfo, "Text", "27 occurrences found.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Close() on item 'FindAndReplace'.", repo.FindAndReplace.SelfInfo, new RecordItemIndex(15));
            repo.FindAndReplace.Self.Close();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

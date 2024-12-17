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
    ///The FindTabRegularExpression recording.
    /// </summary>
    [TestModule("3e0e4776-bfc2-404b-9fa5-a8c702b234c3", ModuleType.Recording, 1)]
    public partial class FindTabRegularExpression : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::UltraEditAutomation.UltraEditAutomationRepository repository.
        /// </summary>
        public static global::UltraEditAutomation.UltraEditAutomationRepository repo = global::UltraEditAutomation.UltraEditAutomationRepository.Instance;

        static FindTabRegularExpression instance = new FindTabRegularExpression();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FindTabRegularExpression()
        {
            text = "";
            AddedExpression = "";
            AddedExpression2 = "";
            Value = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FindTabRegularExpression Instance
        {
            get { return instance; }
        }

#region Variables

        string _text;

        /// <summary>
        /// Gets or sets the value of variable text.
        /// </summary>
        [TestVariable("e61c854a-3602-43dd-aada-38f36ed05d88")]
        public string text
        {
            get { return _text; }
            set { _text = value; }
        }

        string _AddedExpression;

        /// <summary>
        /// Gets or sets the value of variable AddedExpression.
        /// </summary>
        [TestVariable("849e848a-beae-4cc7-bda8-11c6b69b5441")]
        public string AddedExpression
        {
            get { return _AddedExpression; }
            set { _AddedExpression = value; }
        }

        string _AddedExpression2;

        /// <summary>
        /// Gets or sets the value of variable AddedExpression2.
        /// </summary>
        [TestVariable("085610cf-95be-4538-b12f-dc232867b972")]
        public string AddedExpression2
        {
            get { return _AddedExpression2; }
            set { _AddedExpression2 = value; }
        }

        string _Value;

        /// <summary>
        /// Gets or sets the value of variable Value.
        /// </summary>
        [TestVariable("c38b2029-60b2-4144-9540-de33844a7dfd")]
        public string Value
        {
            get { return _Value; }
            set { _Value = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HEXFindReplace.Text1687' at 140;16.", repo.HEXFindReplace.Text1687Info, new RecordItemIndex(0));
            repo.HEXFindReplace.Text1687.Click("140;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Value' with focus on 'HEXFindReplace.Text1687'.", repo.HEXFindReplace.Text1687Info, new RecordItemIndex(1));
            repo.HEXFindReplace.Text1687.PressKeys(Value);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HEXFindReplace.FindASCII' at 6;6.", repo.HEXFindReplace.FindASCIIInfo, new RecordItemIndex(2));
            repo.HEXFindReplace.FindASCII.Click("6;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HEXFindReplace.RegularExpressionsASCIIOnly' at 6;6.", repo.HEXFindReplace.RegularExpressionsASCIIOnlyInfo, new RecordItemIndex(3));
            repo.HEXFindReplace.RegularExpressionsASCIIOnly.Click("6;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(4));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'HEXFindReplace.Text1687' and assigning its value to variable 'text'.", repo.HEXFindReplace.Text1687Info, new RecordItemIndex(5));
            text = repo.HEXFindReplace.Text1687.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HEXFindReplace.Button2' at 10;15.", repo.HEXFindReplace.Button2Info, new RecordItemIndex(6));
            repo.HEXFindReplace.Button2.Click("10;15");
            Delay.Milliseconds(0);
            
            AddedExpression = GetSymbol(repo.Uedit64.MenuItemPlusPlusZeroOrMorePreceding, text);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.MenuItemPlusPlusZeroOrMorePreceding' at 41;13.", repo.Uedit64.MenuItemPlusPlusZeroOrMorePrecedingInfo, new RecordItemIndex(8));
            repo.Uedit64.MenuItemPlusPlusZeroOrMorePreceding.Click("41;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$AddedExpression) on item 'HEXFindReplace.Text1687'.", repo.HEXFindReplace.Text1687Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.HEXFindReplace.Text1687Info, "Text", AddedExpression);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(10));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HEXFindReplace.Button2' at 16;19.", repo.HEXFindReplace.Button2Info, new RecordItemIndex(11));
            repo.HEXFindReplace.Button2.Click("16;19");
            Delay.Milliseconds(0);
            
            AddedExpression2 = GetSymbol(repo.Uedit64.MenuItemAnySingleCharacterExceptN, AddedExpression);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.MenuItemAnySingleCharacterExceptN' at Center.", repo.Uedit64.MenuItemAnySingleCharacterExceptNInfo, new RecordItemIndex(13));
            repo.Uedit64.MenuItemAnySingleCharacterExceptN.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$AddedExpression2) on item 'HEXFindReplace.Text1687'.", repo.HEXFindReplace.Text1687Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.HEXFindReplace.Text1687Info, "Text", AddedExpression2);
            Delay.Milliseconds(0);
            
            ClearTextField(repo.HEXFindReplace.Text1687);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

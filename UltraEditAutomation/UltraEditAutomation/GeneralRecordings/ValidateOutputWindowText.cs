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

namespace UltraEditAutomation.GeneralRecordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidateOutputWindowText recording.
    /// </summary>
    [TestModule("ac540112-662b-4521-bc2b-05443ff3f890", ModuleType.Recording, 1)]
    public partial class ValidateOutputWindowText : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::UltraEditAutomation.UltraEditAutomationRepository repository.
        /// </summary>
        public static global::UltraEditAutomation.UltraEditAutomationRepository repo = global::UltraEditAutomation.UltraEditAutomationRepository.Instance;

        static ValidateOutputWindowText instance = new ValidateOutputWindowText();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateOutputWindowText()
        {
            varTextToValidate = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateOutputWindowText Instance
        {
            get { return instance; }
        }

#region Variables

        string _varTextToValidate;

        /// <summary>
        /// Gets or sets the value of variable varTextToValidate.
        /// </summary>
        [TestVariable("be1df5ba-2a6f-400b-852a-5de8f6d46194")]
        public string varTextToValidate
        {
            get { return _varTextToValidate; }
            set { _varTextToValidate = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'UltraEdit64Bit.OutputWindow'.", repo.UltraEdit64Bit.OutputWindowInfo, new RecordItemIndex(0));
            Validate.Exists(repo.UltraEdit64Bit.OutputWindowInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (WindowText>$varTextToValidate) on item 'UltraEdit64Bit.OutputWindowText'.", repo.UltraEdit64Bit.OutputWindowTextInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.UltraEdit64Bit.OutputWindowTextInfo, "WindowText", varTextToValidate);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.UltraEdit64Bit.OutputWindow, false, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

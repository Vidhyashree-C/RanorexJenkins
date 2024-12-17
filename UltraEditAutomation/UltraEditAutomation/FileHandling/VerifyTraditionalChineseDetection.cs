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
    ///The VerifyTraditionalChineseDetection recording.
    /// </summary>
    [TestModule("4242176f-e1fd-484f-940a-8a565bd9da2c", ModuleType.Recording, 1)]
    public partial class VerifyTraditionalChineseDetection : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::UltraEditAutomation.UltraEditAutomationRepository repository.
        /// </summary>
        public static global::UltraEditAutomation.UltraEditAutomationRepository repo = global::UltraEditAutomation.UltraEditAutomationRepository.Instance;

        static VerifyTraditionalChineseDetection instance = new VerifyTraditionalChineseDetection();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyTraditionalChineseDetection()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyTraditionalChineseDetection Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='950   (ANSI/OEM - Traditional Chinese Big5)') on item 'FormCUltraEditFilesUe20241025T06120.Text950ANSIOEMTraditionalChines'.", repo.FormCUltraEditFilesUe20241025T06120.Text950ANSIOEMTraditionalChinesInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FormCUltraEditFilesUe20241025T06120.Text950ANSIOEMTraditionalChinesInfo, "Text", "950   (ANSI/OEM - Traditional Chinese Big5)");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=229,Height=17}) on item 'FormCUltraEditFilesUe20241025T06120.Text950ANSIOEMTraditionalChines'.", repo.FormCUltraEditFilesUe20241025T06120.Text950ANSIOEMTraditionalChinesInfo, new RecordItemIndex(1));
            Validate.ContainsImage(repo.FormCUltraEditFilesUe20241025T06120.Text950ANSIOEMTraditionalChinesInfo, Text950ANSIOEMTraditionalChines_Screenshot1, Text950ANSIOEMTraditionalChines_Screenshot1_Options);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.FormCUltraEditFilesUe20241025T06120.Text950ANSIOEMTraditionalChines, false, new RecordItemIndex(2));
            
            TraditionalChinese();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage Text950ANSIOEMTraditionalChines_Screenshot1
        { get { return repo.FormCUltraEditFilesUe20241025T06120.Text950ANSIOEMTraditionalChinesInfo.GetScreenshot1(new Rectangle(0, 0, 229, 17)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions Text950ANSIOEMTraditionalChines_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}

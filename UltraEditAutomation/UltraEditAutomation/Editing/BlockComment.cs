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

namespace UltraEditAutomation.Editing
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BlockComment recording.
    /// </summary>
    [TestModule("87020684-07d5-494c-ab73-4720950f7270", ModuleType.Recording, 1)]
    public partial class BlockComment : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::UltraEditAutomation.UltraEditAutomationRepository repository.
        /// </summary>
        public static global::UltraEditAutomation.UltraEditAutomationRepository repo = global::UltraEditAutomation.UltraEditAutomationRepository.Instance;

        static BlockComment instance = new BlockComment();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BlockComment()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BlockComment Instance
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

            //Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'UltraEdit64Bit.Home'.", repo.UltraEdit64Bit.HomeInfo, new RecordItemIndex(0));
            //repo.UltraEdit64Bit.Home.Select();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'UltraEdit64Bit.ToolBar.Goto'.", repo.UltraEdit64Bit.ToolBar.GotoInfo, new RecordItemIndex(1));
            //repo.UltraEdit64Bit.ToolBar.Goto.Press();
            //Delay.Milliseconds(0);
            
            //SelectBlockLine(repo.UltraEdit64Bit.editorScreenInfo);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'UltraEdit64Bit.ToolBar.Coding'.", repo.UltraEdit64Bit.ToolBar.CodingInfo, new RecordItemIndex(3));
            //repo.UltraEdit64Bit.ToolBar.Coding.Select();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UltraEdit64Bit.Comment' at 26;56.", repo.UltraEdit64Bit.CommentInfo, new RecordItemIndex(4));
            //repo.UltraEdit64Bit.Comment.Click("26;56");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.BlockCommentSelection' at 48;6.", repo.Uedit64.BlockCommentSelectionInfo, new RecordItemIndex(5));
            //repo.Uedit64.BlockCommentSelection.Click("48;6");
            //Delay.Milliseconds(0);
            
            //Report.Screenshot(ReportLevel.Info, "User", "", repo.UltraEdit64Bit.editorScreen, false, new RecordItemIndex(6));
            
            // Selecting Text with GoTo
            Report.Log(ReportLevel.Info, "Section", "Selecting Text with GoTo", new RecordItemIndex(7));
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'UltraEdit64Bit.Home'.", repo.UltraEdit64Bit.HomeInfo, new RecordItemIndex(8));
            repo.UltraEdit64Bit.Home.Select();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'UltraEdit64Bit.ToolBar.Goto'.", repo.UltraEdit64Bit.ToolBar.GotoInfo, new RecordItemIndex(9));
            repo.UltraEdit64Bit.ToolBar.Goto.Press();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoTo.RadioButtonLineColumn' at 27;9.", repo.GoTo.RadioButtonLineColumnInfo, new RecordItemIndex(10));
            repo.GoTo.RadioButtonLineColumn.Click("27;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '10/1' with focus on 'GoTo'.", repo.GoTo.SelfInfo, new RecordItemIndex(11));
            repo.GoTo.Self.EnsureVisible();
            Keyboard.Press("10/1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoTo.Goto' at 54;12.", repo.GoTo.GotoInfo, new RecordItemIndex(12));
            repo.GoTo.Goto.Click("54;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'UltraEdit64Bit.ToolBar.Goto'.", repo.UltraEdit64Bit.ToolBar.GotoInfo, new RecordItemIndex(13));
            repo.UltraEdit64Bit.ToolBar.Goto.Press();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoTo.RadioButtonLineColumn' at 50;11.", repo.GoTo.RadioButtonLineColumnInfo, new RecordItemIndex(14));
            repo.GoTo.RadioButtonLineColumn.Click("50;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '15/20' with focus on 'GoTo'.", repo.GoTo.SelfInfo, new RecordItemIndex(15));
            repo.GoTo.Self.EnsureVisible();
            Keyboard.Press("15/20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}' with focus on 'GoTo'.", repo.GoTo.SelfInfo, new RecordItemIndex(16));
            repo.GoTo.Self.EnsureVisible();
            Keyboard.Press("{LShiftKey down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoTo.Goto' at 30;15.", repo.GoTo.GotoInfo, new RecordItemIndex(17));
            repo.GoTo.Goto.Click("30;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey up}' with focus on 'FormCUltraEditFilesUe20241025T06120'.", repo.FormCUltraEditFilesUe20241025T06120.SelfInfo, new RecordItemIndex(18));
            repo.FormCUltraEditFilesUe20241025T06120.Self.EnsureVisible();
            Keyboard.Press("{LShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'UltraEdit64Bit.ToolBar.Coding'.", repo.UltraEdit64Bit.ToolBar.CodingInfo, new RecordItemIndex(19));
            repo.UltraEdit64Bit.ToolBar.Coding.Select();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UltraEdit64Bit.Comment' at 26;56.", repo.UltraEdit64Bit.CommentInfo, new RecordItemIndex(20));
            repo.UltraEdit64Bit.Comment.Click("26;56");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.BlockCommentSelection' at 48;6.", repo.Uedit64.BlockCommentSelectionInfo, new RecordItemIndex(21));
            repo.Uedit64.BlockCommentSelection.Click("48;6");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.UltraEdit64Bit.editorScreen, false, new RecordItemIndex(22));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

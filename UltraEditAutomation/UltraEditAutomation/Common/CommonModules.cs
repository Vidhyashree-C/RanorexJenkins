/*
 * Created by Ranorex
 * User: celestial
 * Date: 16-12-2024
 * Time: 12:27
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

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace UltraEditAutomation.Common
{
    /// <summary>
    /// Description of CommonModules.
    /// </summary>
    [TestModule("83631577-2E62-424D-8013-32D61302C98A", ModuleType.UserCode, 1)]
    public class CommonModules : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CommonModules()
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
        }
    }
}

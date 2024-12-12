using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
    /// Description of KillRunningProcesses.
    /// </summary>
    [TestModule("EA6303D4-5FCD-4F59-A5A3-2CE170654706", ModuleType.UserCode, 1)]
    public class KillRunningProcesses : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public KillRunningProcesses()
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
            
            List<string> processList = new List<string>();
            using (StreamReader reader = new StreamReader(@"Common\ProcessNames.txt"))
            {
                string processName;
                while ((processName = reader.ReadLine()) != null)
                {
                    processList.Add(processName.ToLowerInvariant());
                }
            }
            KillProcesses(processList);
        }
        
        public static void KillProcesses(List<string> processList)
		{
			foreach(var proc in Process.GetProcesses())
			{
				if(processList.Contains(proc.ProcessName.ToLowerInvariant()))
				{
					try
					{
					proc.Kill();
					Report.Info("Process: " + proc.ProcessName + " was killed");
					}
					catch(Exception e)
					{
						Report.Error("Exception thrown while killing process '"+ proc.ProcessName + "': " + e);
					}
				}
			}
		}
    }
}

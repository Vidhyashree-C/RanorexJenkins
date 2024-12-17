﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace UltraEditAutomation.Editing
{
    public partial class NewDocumentCreatetionandotheractions
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
           
        }

        public void startAndEndsWithPre()
        {
    try
    {
        
        if (repo.UltraEdit64Bit.editorScreen1Info.Exists(5000))
        {
            var appScreen = repo.UltraEdit64Bit.editorScreen1;

            
            if (appScreen != null)
            {
                string retrievedText = appScreen.Element.GetAttributeValueText("WindowText").Trim();

                
                Report.Info("Retrieved Text", $"Text: {retrievedText}");

               
                string startPattern = @"^<pre.*?>"; 
                string endPattern = @"</pre>$";    

                
                if (Regex.IsMatch(retrievedText, startPattern) && Regex.IsMatch(retrievedText, endPattern))
                {
                    Report.Success("Verification", "The text starts with <pre> and ends with </pre>.");
                }
                else
                {
                    Report.Failure("Verification", "The text does not start with <pre> or does not end with </pre>.");
                }
            }
            else
            {
                Report.Failure("Editor Screen1", "Editor screen object is null.");
            }
        }
        else
        {
            Report.Failure("Editor Screen1", "The editor screen does not exist.");
        }
    }
    catch (Exception ex)
    {
        Report.Error($"An error occurred: {ex.Message}");
    }
        }

    }
}
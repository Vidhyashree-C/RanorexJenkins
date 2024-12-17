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

namespace UltraEditAutomation.SearchTests
{
    public partial class ValidateOutputWindowStringNotFound
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

      

        public void ValidateFiles(Adapter repoItem)
        {
        	string outputText = repoItem.Element.GetAttributeValueText("WindowText");
        	 List<string> expectedFiles = new List<string>
		    {
		        "99999.txt",
		        "countAll.txt",
		        "f3.txt",
		        "lines.txt",
		        "ReplClipTest.txt",
		        "smalldata.txt",
		        "test.sql",
		        "test3utf8.sql"
		    };
        	
        	 bool allFilesVerified = true;
        	 
		    foreach (string file in expectedFiles)
		    {
		        if (!outputText.Contains(file))
		        {
		            Report.Error($"File not found in output: {file}");
		            allFilesVerified = false;
		        }
		    }
		
		   
		    if (allFilesVerified)
		    {
		        Report.Info("All expected files are present in the output.");
		    }
		    else
		    {
		        Report.Error("Some files are missing from the output.");
		        
		    }
        }

    }
}

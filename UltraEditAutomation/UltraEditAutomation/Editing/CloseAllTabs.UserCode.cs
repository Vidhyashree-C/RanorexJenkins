using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace UltraEditAutomation.Editing
{
    public partial class CloseAllTabs
    {
        private IList<Ranorex.TabPage> tabPages;

        /// <summary>
        /// Closes all open tabs in the UltraEdit application.
        /// </summary>
        private void CloseTabs()
        {
            tabPages = new List<Ranorex.TabPage>();

            var appWindow = repo.UltraEdit64Bit;

            while (true)
            {
                try
                {
                    
                    if (appWindow.TabPageInfo.Exists(5000)) 
                    {
                        tabPages = appWindow.TabPageList.FindChildren<TabPage>();

                        
                        int tabPagesCount = tabPages.Count;
                        Report.Info($"Number of open tabs: {tabPagesCount}");

                        if (tabPagesCount == 0)
                        {
                            Report.Warn("No tabs to close. Exiting loop.");
                            break;
                        }
                    }
                    else
                    {
                        Report.Warn("No tab pages found. Exiting loop.");
                        break;
                    }

                    
                    foreach (var tabPage in tabPages)
                    {
                        try
                        {
                            Report.Info("Tab Page", $"Processing tab: {tabPage}");

                           
                            tabPage.MoveTo();
                            tabPage.Click(WinForms.MouseButtons.Right);

                          
                            var closeOption = repo.Uedit64.CloseCtrlPlusF4;
                            if (closeOption != null && repo.Uedit64.CloseCtrlPlusF4Info.Exists(10000))
                            {
                                closeOption.MoveTo();
                                closeOption.Click();
                                Report.Info("Tab closed successfully.");
                            }
                            else
                            {
                                Report.Warn("Close option not found for the tab.");
                            }

                            var popupWindow = repo.UltraEdit.PopupWindowInfo;
                            if (popupWindow.Exists(2000))
                            {
                                Report.Info("Popup detected. Clicking 'No'.");
                                repo.UltraEdit.PopupWinButtonNo.Click();
                                popupWindow.WaitForNotExists(3000); 
                            }
                            else
                            {
                                Report.Info("No popup detected after closing the tab.");
                            }

                            
                            break;
                        }
                        catch (Exception tabEx)
                        {
                            Report.Error($"An error occurred while processing the tab: {tabEx.Message}");
                        }
                    }
                }
                catch (Exception loopEx)
                {
                    Report.Error($"An error occurred in the main loop: {loopEx.Message}");
                    break;
                }
            }

            Report.Info("All tabs closed successfully, or no tabs were open.");
        }

        private void Init()
        {
            
        }

    }
}

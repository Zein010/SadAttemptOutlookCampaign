using Microsoft.Office.Interop.Excel;
using Outlook=Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace OutlookCampaign
{
    public partial class NewCampaignRibbon
    {
        private void NewCampaignRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void startCampaignButton_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Application outlookApp = new Outlook.Application();
            Outlook.Inspector activeInspector = outlookApp.ActiveInspector();
            if (activeInspector != null)
            { 
                Campaign camp = new Campaign(activeInspector);
                camp.startCampaign();
            }
        }
    }
}

using Microsoft.Office.Interop.Excel;
using Outlook = Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Outlook;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OutlookCampaign
{
    internal class Campaign
    {
        public string[,] data;
        public Outlook.Inspector inspector;
        public Outlook.MailItem mailitem;
        public CampaignSettingsForm settingsForm;
        public Campaign(Outlook.Inspector inspector)
        {
            this.inspector = inspector;


        }
        public void startCampaign()
        {
            data = getData();
            if (data == null)
            {
                return;
            }
            initiateCampaignSettings();



        }
        public string[,] getData()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files (*.xlsx;*.xls)|*.xlsx;*.xls|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                // Add code to process the selected Excel file here
                DialogResult continueMarketing = MessageBox.Show("Are you sure you want to load contents of file " + openFileDialog.FileName + "?", "Confirmation", MessageBoxButtons.YesNo);
                if (continueMarketing == DialogResult.Yes)
                {
                    Form form = new Form1();
                    System.Windows.Forms.ProgressBar progressBar = (System.Windows.Forms.ProgressBar)form.Controls.Find("LoadingEmailsProgressBar", true)[0];
                    progressBar.Minimum = 0;
                    progressBar.Step = 1;
                    System.Windows.Forms.Label progressText = (System.Windows.Forms.Label)form.Controls.Find("LoadingEmailProgressText", true)[0];
                    form.Show();

                    string[,] data = null;
                    Excel.Application excelApp = new Excel.Application();
                    Workbook workbook = excelApp.Workbooks.Open(openFileDialog.FileName);
                    Worksheet worksheet = workbook.Worksheets[1];
                    int columns = worksheet.UsedRange.Columns.Count;
                    int rows = worksheet.UsedRange.Rows.Count;
                    progressBar.Maximum = rows;
                    data = new string[rows, columns];
                    for (int i = 1; i <= rows; i++)
                    {
                        for (int j = 1; j <= columns; j++)
                        {
                            data[i - 1, j - 1] = worksheet.Cells[i, j].Value2 != null ? worksheet.Cells[i, j].Value2.ToString() : "#N/A";
                        }
                        progressText.Text = $"Current progress: {Math.Ceiling(((double)i / rows) * 100)}% ( {i} of  {rows} )";

                        progressBar.PerformStep();

                    }
                    form.Close();
                    return data;

                }
                else
                {
                    CancelCampaign();
                    return null;
                }
            }
            return null;
        }
        public void CancelCampaign()
        {
            MessageBox.Show("List canceled");
            return;
        }
        public void initiateCampaignSettings()
        {
            settingsForm = new CampaignSettingsForm();

            // Get the current outlook application 
            Outlook.Application outlookApp = new Outlook.Application();


            // I have no idea what this is, this is a copy pasta code xD
            NameSpace nameSpace = outlookApp.GetNamespace("MAPI");

            // Get the current mailitem to use with out campaign
            this.mailitem = (Outlook.MailItem)inspector.CurrentItem;
            this.mailitem.Save();

            // Show the subject from the email message in the message box
            List<System.Windows.Forms.TextBox> subjectTextBoxes = settingsForm.Controls.OfType<System.Windows.Forms.TextBox>()
                  .Where(c => c.Tag != null && c.Tag.ToString() == "subjectTextBox")
                  .ToList();
            subjectTextBoxes[3].Text = mailitem.Subject;


            // Show the number of reciepients for this email campaign
            System.Windows.Forms.Label ReciepientsNumberBox = (System.Windows.Forms.Label)settingsForm.Controls.Find("ReciepientsNumberBox", true)[0];
            ReciepientsNumberBox.Text = $"Recipients number: {this.data.GetLength(0)}";


            // Get the senders checkbox, and add the posible senders to this checkbox
            CheckedListBox sendersCheckbox = (CheckedListBox)settingsForm.Controls.Find("SendersCheckListBox", true)[0];
            foreach (Account Acc in nameSpace.Accounts)
                sendersCheckbox.Items.Add(Acc.SmtpAddress, nameSpace.CurrentUser.Address == Acc.SmtpAddress ? true : false);

            ((System.Windows.Forms.Button)settingsForm.Controls.Find("CancelCampaign", true)[0]).Click += Campaign_Click;


            // After initalizing the form, show it for client to edit the required setting
            settingsForm.Show();

        }

        private void Campaign_Click(object sender, EventArgs e)
        {
            settingsForm.Close();
            CancelCampaign();
        }
    }
}

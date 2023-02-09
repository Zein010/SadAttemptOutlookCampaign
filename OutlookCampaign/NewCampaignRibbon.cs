using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Outlook;
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
                    Form form = new Form();
                    ProgressBar progressBar = new ProgressBar();
                    progressBar.Minimum = 0;
                    progressBar.Maximum = 100;
                    progressBar.Step = 1;
                    form.Controls.Add(progressBar);
                    form.Show();
                    for (int i = 0; i <= 100; i++)
                    {
                        progressBar.PerformStep();
                        System.Threading.Thread.Sleep(100);
                    }
                    form.Close();
                    string[,] data = null;
                    Excel.Application excelApp = new Excel.Application();
                    Workbook workbook = excelApp.Workbooks.Open(openFileDialog.FileName);
                    Worksheet worksheet = workbook.Worksheets[1];
                    int columns = worksheet.UsedRange.Columns.Count;
                    int rows = worksheet.UsedRange.Rows.Count;
                    data = new string[rows, columns];
                    for (int i = 1; i <= rows; i++)
                    {
                        for (int j = 1; j <= columns; j++)
                        {
                            data[i - 1, j - 1] = worksheet.Cells[i, j].Value2!=null? worksheet.Cells[i, j].Value2.ToString():"#N/A";
                        }


                    }
                    MessageBox.Show(JsonConvert.SerializeObject(data));
                }
                else
                {
                    MessageBox.Show("List canceled");
                }
            }
        }
    }
}

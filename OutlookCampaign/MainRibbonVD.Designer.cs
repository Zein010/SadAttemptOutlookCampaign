namespace OutlookCampaign
{
    partial class MainRibbonVD : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MainRibbonVD()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutlookCampaign = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.toggleButton1 = this.Factory.CreateRibbonToggleButton();
            this.OutlookCampaign.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutlookCampaign
            // 
            this.OutlookCampaign.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.OutlookCampaign.Groups.Add(this.group1);
            this.OutlookCampaign.Label = "Outlook Campaign";
            this.OutlookCampaign.Name = "OutlookCampaign";
            // 
            // group1
            // 
            this.group1.Items.Add(this.button1);
            this.group1.Items.Add(this.button2);
            this.group1.Items.Add(this.toggleButton1);
            this.group1.Label = "Add-in Configuration";
            this.group1.Name = "group1";
            // 
            // button1
            // 
            this.button1.Label = "Settings";
            this.button1.Name = "button1";
            this.button1.SuperTip = "Change the Add-in settings";
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Label = "Advanced Settings";
            this.button2.Name = "button2";
            this.button2.SuperTip = "Change the Add-in advanced settings";
            // 
            // toggleButton1
            // 
            this.toggleButton1.Label = "Details Before Send";
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.SuperTip = "Display a details window before starting a campaign";
            // 
            // MainRibbonVD
            // 
            this.Name = "MainRibbonVD";
            this.RibbonType = "Microsoft.Outlook.Explorer, Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.OutlookCampaign);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MainRibbonVD_Load);
            this.OutlookCampaign.ResumeLayout(false);
            this.OutlookCampaign.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab OutlookCampaign;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleButton1;
    }

    partial class ThisRibbonCollection
    {
        internal MainRibbonVD MainRibbonVD
        {
            get { return this.GetRibbon<MainRibbonVD>(); }
        }
    }
}

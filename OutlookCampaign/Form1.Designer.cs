namespace OutlookCampaign
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadingEmailsProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadingEmailProgressText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadingEmailsProgressBar
            // 
            this.LoadingEmailsProgressBar.Location = new System.Drawing.Point(12, 73);
            this.LoadingEmailsProgressBar.Name = "LoadingEmailsProgressBar";
            this.LoadingEmailsProgressBar.Size = new System.Drawing.Size(776, 39);
            this.LoadingEmailsProgressBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loading data from excel sheet";
            // 
            // LoadingEmailProgressText
            // 
            this.LoadingEmailProgressText.AutoSize = true;
            this.LoadingEmailProgressText.Location = new System.Drawing.Point(13, 48);
            this.LoadingEmailProgressText.Name = "LoadingEmailProgressText";
            this.LoadingEmailProgressText.Size = new System.Drawing.Size(122, 13);
            this.LoadingEmailProgressText.TabIndex = 2;
            this.LoadingEmailProgressText.Text = "Current progress: % ( of )";
            this.LoadingEmailProgressText.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 144);
            this.Controls.Add(this.LoadingEmailProgressText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadingEmailsProgressBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar LoadingEmailsProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LoadingEmailProgressText;
    }
}
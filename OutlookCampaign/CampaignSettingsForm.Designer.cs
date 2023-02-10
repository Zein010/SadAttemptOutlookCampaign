namespace OutlookCampaign
{
    partial class CampaignSettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ReciepientsNumberBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailDelayNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DelayDeviation = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AutoStartAfterErrorPause = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.SendersCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmailDelayNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayDeviation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoStartAfterErrorPause)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Campaign Details";
            // 
            // ReciepientsNumberBox
            // 
            this.ReciepientsNumberBox.AutoSize = true;
            this.ReciepientsNumberBox.Location = new System.Drawing.Point(13, 44);
            this.ReciepientsNumberBox.Name = "ReciepientsNumberBox";
            this.ReciepientsNumberBox.Size = new System.Drawing.Size(101, 13);
            this.ReciepientsNumberBox.TabIndex = 1;
            this.ReciepientsNumberBox.Text = "Recipients number: ";
            this.ReciepientsNumberBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReciepientsNumberBox.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subjects:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Tag = "subjectTextBox";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Senders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email delay";
            // 
            // EmailDelayNumber
            // 
            this.EmailDelayNumber.Location = new System.Drawing.Point(79, 200);
            this.EmailDelayNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.EmailDelayNumber.Name = "EmailDelayNumber";
            this.EmailDelayNumber.Size = new System.Drawing.Size(42, 20);
            this.EmailDelayNumber.TabIndex = 8;
            this.EmailDelayNumber.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "( Seconds )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Delay Deviation";
            // 
            // DelayDeviation
            // 
            this.DelayDeviation.Location = new System.Drawing.Point(104, 226);
            this.DelayDeviation.Name = "DelayDeviation";
            this.DelayDeviation.Size = new System.Drawing.Size(31, 20);
            this.DelayDeviation.TabIndex = 11;
            this.DelayDeviation.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "( Seconds )";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 252);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(100, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Pause on errors";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "When paused because of errors, auto start after:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // AutoStartAfterErrorPause
            // 
            this.AutoStartAfterErrorPause.Location = new System.Drawing.Point(255, 275);
            this.AutoStartAfterErrorPause.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.AutoStartAfterErrorPause.Name = "AutoStartAfterErrorPause";
            this.AutoStartAfterErrorPause.Size = new System.Drawing.Size(66, 20);
            this.AutoStartAfterErrorPause.TabIndex = 15;
            this.AutoStartAfterErrorPause.Value = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "( Seconds )";
            // 
            // SendersCheckListBox
            // 
            this.SendersCheckListBox.FormattingEnabled = true;
            this.SendersCheckListBox.Location = new System.Drawing.Point(16, 316);
            this.SendersCheckListBox.Name = "SendersCheckListBox";
            this.SendersCheckListBox.Size = new System.Drawing.Size(486, 94);
            this.SendersCheckListBox.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Subject 1: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Subject 2: ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(398, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.Tag = "subjectTextBox";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Subject 3: ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(79, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(398, 20);
            this.textBox3.TabIndex = 22;
            this.textBox3.Tag = "subjectTextBox";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Subject 4: ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(79, 168);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(398, 20);
            this.textBox4.TabIndex = 24;
            this.textBox4.Tag = "subjectTextBox";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Confirm And Start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CampaignSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 454);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SendersCheckListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AutoStartAfterErrorPause);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DelayDeviation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmailDelayNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReciepientsNumberBox);
            this.Controls.Add(this.label1);
            this.Name = "CampaignSettingsForm";
            this.Text = "CampaignSettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.EmailDelayNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayDeviation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoStartAfterErrorPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ReciepientsNumberBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown EmailDelayNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown DelayDeviation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown AutoStartAfterErrorPause;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox SendersCheckListBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
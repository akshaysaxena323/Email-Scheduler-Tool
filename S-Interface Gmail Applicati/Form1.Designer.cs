namespace S_Interface_Gmail_Applicati
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subjectname = new System.Windows.Forms.TextBox();
            this.subjectemail = new System.Windows.Forms.TextBox();
            this.emailsubject = new System.Windows.Forms.TextBox();
            this.content = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Body = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Schedulebtn = new System.Windows.Forms.Button();
            this.ReadEmails = new System.Windows.Forms.Button();
            this.emailTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipient\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recipient\'s Email ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email Body";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 526);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email to be Scheduled at";
            // 
            // subjectname
            // 
            this.subjectname.Location = new System.Drawing.Point(213, 35);
            this.subjectname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.subjectname.Name = "subjectname";
            this.subjectname.Size = new System.Drawing.Size(224, 38);
            this.subjectname.TabIndex = 5;
            // 
            // subjectemail
            // 
            this.subjectemail.Location = new System.Drawing.Point(213, 97);
            this.subjectemail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.subjectemail.Name = "subjectemail";
            this.subjectemail.Size = new System.Drawing.Size(224, 38);
            this.subjectemail.TabIndex = 6;
            // 
            // emailsubject
            // 
            this.emailsubject.Location = new System.Drawing.Point(213, 160);
            this.emailsubject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailsubject.Name = "emailsubject";
            this.emailsubject.Size = new System.Drawing.Size(224, 38);
            this.emailsubject.TabIndex = 7;
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(213, 229);
            this.content.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(400, 276);
            this.content.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SName,
            this.SEmail,
            this.EmailSub,
            this.DateTime,
            this.Body});
            this.dataGridView1.Location = new System.Drawing.Point(730, 35);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(694, 522);
            this.dataGridView1.TabIndex = 14;
            // 
            // SName
            // 
            this.SName.HeaderText = "Recipeint Name";
            this.SName.Name = "SName";
            this.SName.ReadOnly = true;
            // 
            // SEmail
            // 
            this.SEmail.HeaderText = "Email ID";
            this.SEmail.Name = "SEmail";
            this.SEmail.ReadOnly = true;
            // 
            // EmailSub
            // 
            this.EmailSub.HeaderText = "Email Subject";
            this.EmailSub.Name = "EmailSub";
            this.EmailSub.ReadOnly = true;
            // 
            // DateTime
            // 
            this.DateTime.HeaderText = "Time";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            // 
            // Body
            // 
            this.Body.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Body.HeaderText = "Body";
            this.Body.MaxInputLength = 327675656;
            this.Body.Name = "Body";
            this.Body.ReadOnly = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalExtent = 120;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(213, 695);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(1211, 196);
            this.listBox1.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Addbtn);
            this.panel1.Controls.Add(this.Schedulebtn);
            this.panel1.Controls.Add(this.ReadEmails);
            this.panel1.Location = new System.Drawing.Point(213, 563);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 96);
            this.panel1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(513, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 39);
            this.label10.TabIndex = 21;
            this.label10.Text = "Unread Mails";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(108, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(316, 39);
            this.label9.TabIndex = 20;
            this.label9.Text = "Add to Mailing List";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(899, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(359, 39);
            this.label8.TabIndex = 19;
            this.label8.Text = "Schedule Mailing List";
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Addbtn.BackgroundImage = global::S_Interface_Gmail_Applicati.Properties.Resources.List_Icon_Image;
            this.Addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Addbtn.Location = new System.Drawing.Point(129, 33);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(115, 60);
            this.Addbtn.TabIndex = 11;
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Schedulebtn
            // 
            this.Schedulebtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Schedulebtn.BackgroundImage = global::S_Interface_Gmail_Applicati.Properties.Resources.Outlook_Email_Scheduling1;
            this.Schedulebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Schedulebtn.Location = new System.Drawing.Point(938, 33);
            this.Schedulebtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Schedulebtn.Name = "Schedulebtn";
            this.Schedulebtn.Size = new System.Drawing.Size(108, 60);
            this.Schedulebtn.TabIndex = 13;
            this.Schedulebtn.UseVisualStyleBackColor = false;
            this.Schedulebtn.Click += new System.EventHandler(this.Schedulebtn_Click);
            // 
            // ReadEmails
            // 
            this.ReadEmails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReadEmails.BackgroundImage = global::S_Interface_Gmail_Applicati.Properties.Resources.email_icon;
            this.ReadEmails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReadEmails.Location = new System.Drawing.Point(517, 33);
            this.ReadEmails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReadEmails.Name = "ReadEmails";
            this.ReadEmails.Size = new System.Drawing.Size(111, 60);
            this.ReadEmails.TabIndex = 16;
            this.ReadEmails.UseVisualStyleBackColor = false;
            this.ReadEmails.Click += new System.EventHandler(this.ReadEmails_Click);
            // 
            // emailTime
            // 
            this.emailTime.Location = new System.Drawing.Point(213, 518);
            this.emailTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailTime.Name = "emailTime";
            this.emailTime.Size = new System.Drawing.Size(224, 38);
            this.emailTime.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1404, 783);
            this.Controls.Add(this.emailTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.content);
            this.Controls.Add(this.emailsubject);
            this.Controls.Add(this.subjectemail);
            this.Controls.Add(this.subjectname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Email Scheduler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox subjectname;
        private System.Windows.Forms.TextBox subjectemail;
        private System.Windows.Forms.TextBox emailsubject;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Schedulebtn;
        private System.Windows.Forms.Button ReadEmails;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Body;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emailTime;
    }
}


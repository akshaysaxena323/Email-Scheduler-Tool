using System;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Quartz;
using Quartz.Impl;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using Google.Apis.Util.Store;

namespace S_Interface_Gmail_Applicati
{
    public partial class Form1 : Form
    {
        Scheduler sc = new Scheduler();

        public Form1()
        {

            InitializeComponent();
            readtext();
            
        }

        private void readtext()
        {
            StreamReader reader = new StreamReader(File.OpenRead(@"Input.csv"));
            List<string> listA = new List<String>();
            List<string> listB = new List<String>();
            List<string> listC = new List<String>();
            List<string> listD = new List<String>();
            List<string> listE = new List<string>();
 
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (!String.IsNullOrWhiteSpace(line))
                {
                    string[] values = line.Split(',');
                    if (values.Length >= 5)
                    {
                        listA.Add(values[0]);
                        listB.Add(values[1]);
                        listC.Add(values[2]);
                        listD.Add(values[3]);
                        listE.Add(values[4]);
                    }
                }
            }
            string[] firstlistA = listA.ToArray();
            string[] firstlistB = listB.ToArray();
            string[] firstlistC = listC.ToArray();
            string[] firstlistD = listD.ToArray();
            string[] firstlistE = listE.ToArray();

            

            for (int i = 1; i < firstlistA.Length; i++)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = firstlistA.GetValue(i).ToString();
                dataGridView1.Rows[n].Cells[1].Value = firstlistB.GetValue(i).ToString();
                dataGridView1.Rows[n].Cells[2].Value = firstlistC.GetValue(i).ToString();
                dataGridView1.Rows[n].Cells[3].Value = firstlistD.GetValue(i).ToString();
                dataGridView1.Rows[n].Cells[4].Value = firstlistE.GetValue(i).ToString();
            }

            /*
            int n = dataGridView1.Rows.Add();

            for (int i = 1; i < firstlistA.Length; i++)
            {
                dataGridView1.Rows[n].Cells[0].Value = firstlistA.GetValue(i).ToString();
            }

            for (int i = 1; i < firstlistB.Length; i++)
            {
                dataGridView1.Rows[n].Cells[1].Value = firstlistB.GetValue(i).ToString();
            }

            for (int i = 1; i < firstlistC.Length; i++)
            {
                dataGridView1.Rows[n].Cells[2].Value = firstlistC.GetValue(i).ToString();
            }

            for (int i = 1; i < firstlistD.Length; i++)
            {
                dataGridView1.Rows[n].Cells[3].Value = firstlistD.GetValue(i).ToString();
            }

            for (int i = 1; i < firstlistE.Length; i++)
            {
                dataGridView1.Rows[n].Cells[4].Value = firstlistE.GetValue(i).ToString();
            }
            */
        }

        // Email Validation
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            // Subject Name Field Validation
            if (subjectname.Text != null && subjectemail.Text != null && IsValidEmail(subjectemail.Text) == true && emailsubject.Text != null)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = subjectname.Text;
                dataGridView1.Rows[n].Cells[1].Value = subjectemail.Text;
                dataGridView1.Rows[n].Cells[2].Value = emailsubject.Text;
                dataGridView1.Rows[n].Cells[3].Value = emailTime.Text;
                dataGridView1.Rows[n].Cells[4].Value = content.Text;

                subjectname.Clear();
                subjectemail.Clear();
                emailsubject.Clear();
                content.Clear();
            }

            else
            {
                MessageBox.Show("Please Enter Valid Details");
    
            }

        }



        private void Schedulebtn_Click(object sender, EventArgs e)
        {
            DateTime curDate = System.DateTime.Now;
            foreach (DataGridViewRow Datarow in dataGridView1.Rows)
            {
                if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null && Datarow.Cells[2].Value != null && Datarow.Cells[3].Value != null)
                {

                    String name = Datarow.Cells[0].Value.ToString();
                    String email = Datarow.Cells[1].Value.ToString();
                    String sub = Datarow.Cells[2].Value.ToString();
                    //DateTime date = Convert.ToDateTime(Datarow.Cells[3].Value);
                    DateTime date = curDate.AddSeconds(double.Parse(Datarow.Cells[3].Value.ToString()));
                    String body = Datarow.Cells[4].Value.ToString();
                    sc.Start(name, email, sub, body, date);

                }

            }

            Schedulebtn.Enabled = false;
            MessageBox.Show("Emails scheduled successfully!");
        }

        private void ReadEmails_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Readmails re = new Readmails();

            string[] emailarray = new string[10];
            emailarray = re.GetEmails();
            
            for (int i = 0; i < emailarray.Length; i++)
            {
                listBox1.Items.Add(emailarray[i]);
            }         

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sc.Stop();
            Application.Exit();
        }
    }

}

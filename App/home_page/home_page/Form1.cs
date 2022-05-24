using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace home_page
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = @"..\Debug\Login\login.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            Test_task_manager.Task_manager tsk=new Test_task_manager.Task_manager();
            DialogResult dialogResult=tsk.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Test_task_manager.Task_manager tsk = new Test_task_manager.Task_manager();
            DialogResult dialogResult = tsk.ShowDialog();
        }

       
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour < 12 && DateTime.Now.Hour>=4)
            {
                label1.Text = "Good Morning";
            }
            else if (DateTime.Now.Hour < 17)
            {
                label1.Text = "Good Afternoon";
            }
            else
            {
                label1.Text = "Good Evening";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] loginfo = File.ReadAllLines(path);
            if(loginfo.Length > 0)
            {
                panel3.Hide();
                if (DateTime.Now.Hour < 12 && DateTime.Now.Hour >= 4)
                {
                    label1.Text = "Good Morning";
                }
                else if (DateTime.Now.Hour < 17&& DateTime.Now.Hour>=12)
                {
                    label1.Text = "Good Afternoon";
                }
                else
                {
                    label1.Text = "Good Evening";
                }
            }
            else
            {
                panel3.Show();
                txtuserID.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MentalHealth.MentalHealth mn=new MentalHealth.MentalHealth();
            DialogResult result=mn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Confss confss=new Confss();
            this.Visible = false;
            confss.Show();
        }

        private void btnconf_Click(object sender, EventArgs e)
        {
            Confss confss = new Confss();
            this.Visible = false;
            confss.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Visible=true;
            this.Visible = false;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Visible=true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpf_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Visible=true;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            login();
        }

        private void txtuserID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtpswd.Focus();
            }
        }

        private void txtpswd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                login();
            }
        }

        public void login()
        {
            var data = new Dictionary<string, string>()
            {
                {"HOD","HOD1234" },
                {"Emp1","Emp11234"},
                {"Emp2","Emp21234"}
            };
            string result;
            if (data.ContainsKey(txtuserID.Text))
            {
                data.TryGetValue(txtuserID.Text, out result);
                if (result==txtpswd.Text)
                {
                    if (txtuserID.Text=="HOD")
                    {
                        HODapplication hODapplication = new HODapplication();
                        hODapplication.Show();
                        this.Hide();
                    }
                    else
                    {
                        try
                        {
                            using (StreamWriter sw = new StreamWriter(path))
                            {
                                sw.Write(txtuserID.Text);
                            }
                        }
                        catch(Exception wx)
                        {
                            MessageBox.Show(wx.ToString());
                        }
                        panel3.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect password");
                }
            }
            else
            {
                MessageBox.Show("This User ID doesn't exist");
            }
        }
    }
}

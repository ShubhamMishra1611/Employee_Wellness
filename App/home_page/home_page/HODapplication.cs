using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace home_page
{
    public partial class HODapplication : Form
    {
        public HODapplication()
        {
            InitializeComponent();
        }
        string path = @"..\Debug";
        string project = @"..\Debug\Project\Project.txt";
        string filepath = @"..\Debug\Employee.txt";
        private void HODapplication_Load(object sender, EventArgs e)
        {
            string[] names = Directory.GetFiles(path, "*.txt");//Add all employee name
            foreach (string name in names)
            {
                string get_name = name;
                string newname = get_name.Replace("..\\Debug\\", "").Replace(".txt","") ;
                listBox1.Items.Add(newname);
            }

            string[] project_name = File.ReadAllLines(project); 
            foreach (string name in project_name)
            {
                listBox2.Items.Add(name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string[] lines = File.ReadAllLines(filepath);
            chart1.Series[0].Points.Clear();
            foreach(string line in lines)
            {
                string[] emp_data = line.Split(' ');
                string task_name=emp_data[0];
                DateTime deadline = Convert.ToDateTime(emp_data[2]);
                DateTime dt = DateTime.Now;
                int remaining_hours = (int)deadline.Subtract(dt).TotalHours;//
                int task_value = Convert.ToInt32(emp_data[1]);
                int priority = Convert.ToInt32(emp_data[3]);
                int importance = (task_value*priority*110)/remaining_hours;
                richTextBox1.Text=richTextBox1.Text+"Project Name "+task_name+"\n" +
                    "    Project Type "+task_value+"\n"+"    Project Deadline "+emp_data[2]+"\n    Project Priority level "+priority+"\n\n";
                if(importance > 500)
                {
                    MessageBox.Show("This employee has busy schedule this week.");
                }
                else if(importance < 0)
                {
                    continue;
                }
                chart1.Series[0].Points.AddXY(task_name, task_value);
            }            
        }

        public void GetProgressReport(string projectname)
        {
            richTextBox2.Clear();
            richTextBox2.Text=listBox2.SelectedItem.ToString();
            richTextBox2.Text+=" is being done by:";
            int sum_of_all_PL = 0;
            int sum_of_given_PL = 0;
            string[] names = Directory.GetFiles(path, "*.txt");
            foreach(string name in names)
            {
                string[] lines=File.ReadAllLines(name);
                foreach(string line in lines)
                {
                    string[] vs = line.Split(' ');
                    if(vs[0]==projectname)
                    {
                        sum_of_given_PL+=Convert.ToInt32(vs[3]);
                        richTextBox2.Text+="\n    "+name;
                    }
                    sum_of_all_PL+=Convert.ToInt32(vs[3]);
                }
            }
            int k = ((sum_of_given_PL*100)/sum_of_all_PL);
            chart2.Series[0].Points.AddXY(projectname,k);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart2.Series[0].Points.Clear();
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                GetProgressReport(listBox2.Items[i].ToString());
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

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
        List<int> angle = new List<int>();
        List<Color> colors = new List<Color>();
        int sum = 0;
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
            chart2.Titles.Add("Progress");
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
            //chart2.Series[0].X
            chart2.Series[0].Points.AddXY(projectname,k);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        { 
            chart2.Series.Clear();
            for(int i = 0; i < listBox2.Items.Count; i++)
            {
                GetProgressReport(listBox2.Items[i].ToString());
            }
            //GetProgressReport(listBox2.SelectedItems.ToString()); 
        }

       

        /*public void DrawPie(int[] myPiePerecents, Color[] myPieColors, Graphics myPieGraphic, Point myPieLocation, Size myPieSize)
        {
            int sum = 0;
            foreach (int percent_loopVariable in myPiePerecents)
            {
                sum += percent_loopVariable;
            }

            if (sum != 100)
            {
                MessageBox.Show("Sum Do Not Add Up To 100.");
            }

            if (myPiePerecents.Length != myPieColors.Length)
            {
                MessageBox.Show("There Must Be The Same Number Of Percents And Colors.");
            }

            int PiePercentTotal = 0;
            for (int PiePercents = 0; PiePercents<myPiePerecents.Length; PiePercents++)
            {
                using (SolidBrush brush = new SolidBrush(myPieColors[PiePercents]))
                {
                    myPieGraphic.FillPie(brush, new Rectangle(new Point(10, 10), myPieSize), Convert.ToSingle(PiePercentTotal * 360 / 100), Convert.ToSingle(myPiePerecents[PiePercents] * 360 / 100));
                }
                PiePercentTotal += myPiePerecents[PiePercents];
            }
            return;
        }*/

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

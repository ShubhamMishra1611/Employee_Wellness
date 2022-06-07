using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.IO;

namespace Test_task_manager
{
    public partial class Task_manager : Form
    {
        public Task_manager()
        {
            InitializeComponent();
        }
        #region variables_declaration
        string path = @"..\Debug\Login\login.txt";
        string username;//name of the desires user        
        Dictionary<int, Dictionary<string,string>> map = new Dictionary<int, Dictionary<string, string>>();
        #endregion

        FileInfo fi = new FileInfo(@"..\Debug\Employee.txt");



        static string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        static string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\Debug\Task_excel.xlsx");
        string FileName = Path.GetFullPath(sFile);
        private void btnAddTask_Click(object sender, EventArgs e)
        {
              if (btnAddTask.Text=="+Add new task")
            {
                btnAddTask.Text="No, I have no work!!!";
                panel1.Visible=true;
            }
            else
            {
                btnAddTask.Text="+Add new task";
                panel1.Visible =false;
            }
            
        }

        public void add_task_()
        {
            string filepath = @"..\Debug\Employee.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(filepath))
                {
                    sw.Write(TextBox_name.Text);
                    string task_name = comboBox1.Text;
                    int task_value = 0;
                    switch (task_name)
                    {
                        case "Meeting":
                            task_value = 5;
                            break;
                        case "Personal":
                            task_value = 3;
                            break;
                        case "Project":
                            task_value = 10;
                            break;
                        default:
                            task_value = 5;
                            break;
                    }
                    sw.Write((int)task_value);
                    sw.Write(dateTimePicker1.Text);
                    sw.Write(domainUpDown1.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_task_();
        }
        public void update()
        {
            chart1.Series[0].Points.Clear();
            string[] lines=File.ReadAllLines(@"..\Debug\Employee.txt");
            foreach (string line in lines)
            {
                string[] emp_data = line.Split(' ');
                string task_name = emp_data[0];
                DateTime deadline = Convert.ToDateTime(emp_data[2]);
                DateTime dt = DateTime.Now;
                int remaining_hours = (int)deadline.Subtract(dt).TotalHours;//
                int task_value = Convert.ToInt32(emp_data[1]);
                int priority = Convert.ToInt32(emp_data[3]);
                int importance = (task_value*priority*110)/remaining_hours;
                if (importance < 0)
                {
                    continue;
                }
                chart1.Series[0].Points.AddXY(task_name, importance);
                //map.Add(importance, new Dictionary<string, string>());
                //map[importance].Add(task_name, Convert.ToString(deadline));
            }
            #region find_top_three
            //------------------Get to know the top 3 -------------------------\\
            /*map.OrderByDescending(x => x.Key);

            try
            {
                Taskimp1.Text ="You're very close to deadline of "+
                    map.ElementAt(0).Value.ElementAt(0).Key+"\n Due date : "+
                    map.ElementAt(0).Value.ElementAt(0).Value+"\n This should be your First task.";
            }
            catch(Exception e)
            {
                Taskimp1.Text = "Hurrah No work";
            }
            try
            {
                Taskimp2.Text ="You're very close to deadline of "+
                    map.ElementAt(1).Value.ElementAt(0).Key+"\n Due date : "+
                    map.ElementAt(1).Value.ElementAt(0).Value+"\n This should be your Second task.";
            }
            catch(Exception e)
            {
                Taskimp2.Text="Hurrah No work";
            }
            try
            {
                Taskimp3.Text ="You're very close to deadline of "+
                    map.ElementAt(2).Value.ElementAt(0).Key+"\n Due date : "+
                    map.ElementAt(2).Value.ElementAt(0).Value+"\n This should be your First task.";
            }
            catch(Exception e)
            {
                Taskimp3.Text="Hurrah No work";
            }
            map.Clear();

            //-----------------------------------Get to know top 3--------------------------------------------\\
            #endregion*/
        }

        private void tmrupdate_Tick(object sender, EventArgs e)
        {
        }
        private void Task_manager_Load(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(path);
            FileStream fs=fi.Open(FileMode.OpenOrCreate,FileAccess.Read,FileShare.Read);
            StreamReader streamReader = new StreamReader(fs);   
            string line=streamReader.ReadToEnd();
            username=line;
            update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutBox1 abt=new AboutBox1();
            abt.ShowDialog();
        }

        private void addTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_task_();
        }

        private void Task_manager_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

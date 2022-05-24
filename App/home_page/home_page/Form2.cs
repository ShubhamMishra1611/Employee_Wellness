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
using Excel = Microsoft.Office.Interop.Excel;

namespace home_page
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        static string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\Debug\Task_excel.xlsx");
        string FileName = Path.GetFullPath(sFile);
        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(FileName);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            xlWorksheet.Cells[1, 6]=textBox2.Text;
            xlApp.Visible=false;
            xlApp.UserControl=false;
            xlApp.ScreenUpdating=false;
            xlApp.DisplayAlerts=false;
            xlApp.AutomationSecurity=Microsoft.Office.Core.MsoAutomationSecurity.msoAutomationSecurityForceDisable;
            xlApp.AskToUpdateLinks=false;
            xlWorkbook.Save();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            
            //Marshal.ReleaseComObject(xlRange);
            //Marshal.ReleaseComObject(xlWorksheet);
            
            xlWorkbook.Close();
           // Marshal.ReleaseComObject(xlWorkbook);

            xlApp.Quit();
            this.Visible=false;
            Form1 form1 = new Form1();
            form1.Visible=true;
            //Marshal.ReleaseComObject(xlApp);

            Cursor.Current = Cursors.Default;

        }
    }
}

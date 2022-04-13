using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_page
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour < 12 && DateTime.Now.Hour>4)
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
            if (DateTime.Now.Hour < 12 && DateTime.Now.Hour > 4)
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
    }
}

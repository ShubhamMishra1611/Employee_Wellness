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
    public partial class Confss : Form
    {
        public Confss()
        {
            InitializeComponent();
        }
        
        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
                Form1 form1 = new Form1();
                form1.Visible=true;
            }

        }

        private void Confss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
                Form1 form1 = new Form1();
                form1.Visible=true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

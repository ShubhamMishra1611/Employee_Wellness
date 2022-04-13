namespace home_page
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnpf = new System.Windows.Forms.Button();
            this.btntskmng = new System.Windows.Forms.Button();
            this.btnmf = new System.Windows.Forms.Button();
            this.btnconf = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(386, 209);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(721, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(376, 209);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 467);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(386, 202);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(721, 468);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(375, 200);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(8, 647);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(157, 34);
            this.btnlogout.TabIndex = 4;
            this.btnlogout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Greetings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnconf);
            this.panel1.Controls.Add(this.btnmf);
            this.panel1.Controls.Add(this.btnpf);
            this.panel1.Controls.Add(this.btntskmng);
            this.panel1.Location = new System.Drawing.Point(8, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 560);
            this.panel1.TabIndex = 6;
            // 
            // btnpf
            // 
            this.btnpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpf.Location = new System.Drawing.Point(8, 102);
            this.btnpf.Name = "btnpf";
            this.btnpf.Size = new System.Drawing.Size(176, 51);
            this.btnpf.TabIndex = 8;
            this.btnpf.Text = "Physical Fitness";
            this.btnpf.UseVisualStyleBackColor = true;
            // 
            // btntskmng
            // 
            this.btntskmng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntskmng.Location = new System.Drawing.Point(8, 54);
            this.btntskmng.Name = "btntskmng";
            this.btntskmng.Size = new System.Drawing.Size(176, 51);
            this.btntskmng.TabIndex = 7;
            this.btntskmng.Text = "Task Manager";
            this.btntskmng.UseVisualStyleBackColor = true;
            this.btntskmng.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnmf
            // 
            this.btnmf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmf.Location = new System.Drawing.Point(8, 150);
            this.btnmf.Name = "btnmf";
            this.btnmf.Size = new System.Drawing.Size(176, 51);
            this.btnmf.TabIndex = 9;
            this.btnmf.Text = "Mental Fitness";
            this.btnmf.UseVisualStyleBackColor = true;
            // 
            // btnconf
            // 
            this.btnconf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconf.Location = new System.Drawing.Point(8, 196);
            this.btnconf.Name = "btnconf";
            this.btnconf.Size = new System.Drawing.Size(176, 51);
            this.btnconf.TabIndex = 10;
            this.btnconf.Text = "Confession";
            this.btnconf.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(1129, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 28);
            this.panel2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btntskmng;
        private System.Windows.Forms.Button btnpf;
        private System.Windows.Forms.Button btnconf;
        private System.Windows.Forms.Button btnmf;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
    }
}


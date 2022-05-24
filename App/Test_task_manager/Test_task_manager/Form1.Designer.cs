namespace Test_task_manager
{
    partial class Task_manager
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.Taskimp1 = new System.Windows.Forms.Label();
            this.Taskimp2 = new System.Windows.Forms.Label();
            this.Taskimp3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TextBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrupdate = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.YEAH = new System.Windows.Forms.ToolStripMenuItem();
            this.sdsadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OKAY = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfsafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddTask
            // 
            this.btnAddTask.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Location = new System.Drawing.Point(26, 8);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(174, 37);
            this.btnAddTask.TabIndex = 0;
            this.btnAddTask.Text = "+Add new task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // Taskimp1
            // 
            this.Taskimp1.AutoSize = true;
            this.Taskimp1.BackColor = System.Drawing.Color.Transparent;
            this.Taskimp1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taskimp1.Location = new System.Drawing.Point(45, 224);
            this.Taskimp1.Name = "Taskimp1";
            this.Taskimp1.Size = new System.Drawing.Size(42, 23);
            this.Taskimp1.TabIndex = 1;
            this.Taskimp1.Text = "NO";
            // 
            // Taskimp2
            // 
            this.Taskimp2.AutoSize = true;
            this.Taskimp2.BackColor = System.Drawing.Color.Transparent;
            this.Taskimp2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taskimp2.Location = new System.Drawing.Point(428, 224);
            this.Taskimp2.Name = "Taskimp2";
            this.Taskimp2.Size = new System.Drawing.Size(42, 23);
            this.Taskimp2.TabIndex = 2;
            this.Taskimp2.Text = "NO";
            // 
            // Taskimp3
            // 
            this.Taskimp3.AutoSize = true;
            this.Taskimp3.BackColor = System.Drawing.Color.Transparent;
            this.Taskimp3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taskimp3.Location = new System.Drawing.Point(811, 224);
            this.Taskimp3.Name = "Taskimp3";
            this.Taskimp3.Size = new System.Drawing.Size(42, 23);
            this.Taskimp3.TabIndex = 3;
            this.Taskimp3.Text = "NO";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(49, 450);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "TASK";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1070, 312);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(66, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Watch out your all tasks:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(1026, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 26);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.domainUpDown1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(165, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 506);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(233, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add task";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 34);
            this.label6.TabIndex = 8;
            this.label6.Text = "Priority Level:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "DeadLine of task";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Task Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Task name";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Location = new System.Drawing.Point(321, 307);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(234, 23);
            this.domainUpDown1.TabIndex = 4;
            this.domainUpDown1.Text = "Priority_Level";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(321, 267);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Meeting",
            "Project",
            "Personal"});
            this.comboBox1.Location = new System.Drawing.Point(321, 223);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // TextBox_name
            // 
            this.TextBox_name.Location = new System.Drawing.Point(321, 179);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.Size = new System.Drawing.Size(234, 23);
            this.TextBox_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 57);
            this.label2.TabIndex = 0;
            this.label2.Text = "                            Got new work!!! \r\n\r\nAdd it here and we will take care" +
    " of management ;-) 😉\r\n";
            // 
            // tmrupdate
            // 
            this.tmrupdate.Interval = 3000;
            this.tmrupdate.Tick += new System.EventHandler(this.tmrupdate_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.YEAH,
            this.OKAY});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 52);
            // 
            // YEAH
            // 
            this.YEAH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdsadToolStripMenuItem});
            this.YEAH.Name = "YEAH";
            this.YEAH.Size = new System.Drawing.Size(101, 24);
            this.YEAH.Text = "a";
            // 
            // sdsadToolStripMenuItem
            // 
            this.sdsadToolStripMenuItem.Name = "sdsadToolStripMenuItem";
            this.sdsadToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.sdsadToolStripMenuItem.Text = "sdsad";
            // 
            // OKAY
            // 
            this.OKAY.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdfsafToolStripMenuItem});
            this.OKAY.Name = "OKAY";
            this.OKAY.Size = new System.Drawing.Size(101, 24);
            this.OKAY.Text = "asd";
            // 
            // sdfsafToolStripMenuItem
            // 
            this.sdfsafToolStripMenuItem.Name = "sdfsafToolStripMenuItem";
            this.sdfsafToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.sdfsafToolStripMenuItem.Text = "sdfsaf";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.addTaskToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(138, 52);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.exitToolStripMenuItem.Text = "Add Task";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // addTaskToolStripMenuItem
            // 
            this.addTaskToolStripMenuItem.Name = "addTaskToolStripMenuItem";
            this.addTaskToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.addTaskToolStripMenuItem.Text = "Exit";
            this.addTaskToolStripMenuItem.Click += new System.EventHandler(this.addTaskToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(945, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Go Home";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Task_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test_task_manager.Properties.Resources.Task_Manager;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 800);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Taskimp3);
            this.Controls.Add(this.Taskimp2);
            this.Controls.Add(this.Taskimp1);
            this.Controls.Add(this.btnAddTask);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Task_manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Task_manager_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Task_manager_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label Taskimp1;
        private System.Windows.Forms.Label Taskimp2;
        private System.Windows.Forms.Label Taskimp3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TextBox_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmrupdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem YEAH;
        private System.Windows.Forms.ToolStripMenuItem OKAY;
        private System.Windows.Forms.ToolStripMenuItem sdsadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdfsafToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTaskToolStripMenuItem;
        private System.Windows.Forms.Button button3;
    }
}


namespace CityConsole
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donationRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donationHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Attendance = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_Directory = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label_Time = new System.Windows.Forms.Label();
            this.timer_SystemTime = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 33);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberToolStripMenuItem,
            this.attendanceRecordToolStripMenuItem,
            this.donationRecordToolStripMenuItem,
            this.noteToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New...";
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.memberToolStripMenuItem.Text = "Member";
            this.memberToolStripMenuItem.Click += new System.EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // attendanceRecordToolStripMenuItem
            // 
            this.attendanceRecordToolStripMenuItem.Name = "attendanceRecordToolStripMenuItem";
            this.attendanceRecordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.attendanceRecordToolStripMenuItem.Text = "Attendance Record";
            this.attendanceRecordToolStripMenuItem.Click += new System.EventHandler(this.attendanceRecordToolStripMenuItem_Click);
            // 
            // donationRecordToolStripMenuItem
            // 
            this.donationRecordToolStripMenuItem.Name = "donationRecordToolStripMenuItem";
            this.donationRecordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.donationRecordToolStripMenuItem.Text = "Donation Record";
            // 
            // noteToolStripMenuItem
            // 
            this.noteToolStripMenuItem.Name = "noteToolStripMenuItem";
            this.noteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noteToolStripMenuItem.Text = "Note";
            this.noteToolStripMenuItem.Click += new System.EventHandler(this.noteToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendanceHistoryToolStripMenuItem,
            this.donationHistoryToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // attendanceHistoryToolStripMenuItem
            // 
            this.attendanceHistoryToolStripMenuItem.Name = "attendanceHistoryToolStripMenuItem";
            this.attendanceHistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.attendanceHistoryToolStripMenuItem.Text = "Attendance History";
            // 
            // donationHistoryToolStripMenuItem
            // 
            this.donationHistoryToolStripMenuItem.Name = "donationHistoryToolStripMenuItem";
            this.donationHistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.donationHistoryToolStripMenuItem.Text = "Donation History";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button_Attendance
            // 
            this.button_Attendance.Location = new System.Drawing.Point(608, 33);
            this.button_Attendance.Name = "button_Attendance";
            this.button_Attendance.Size = new System.Drawing.Size(180, 81);
            this.button_Attendance.TabIndex = 2;
            this.button_Attendance.Text = "Attendance";
            this.button_Attendance.UseVisualStyleBackColor = true;
            this.button_Attendance.Click += new System.EventHandler(this.button_Attendance_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(608, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 81);
            this.button3.TabIndex = 4;
            this.button3.Text = "Donation";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button_Directory
            // 
            this.button_Directory.Location = new System.Drawing.Point(608, 120);
            this.button_Directory.Name = "button_Directory";
            this.button_Directory.Size = new System.Drawing.Size(180, 81);
            this.button_Directory.TabIndex = 3;
            this.button_Directory.Text = "Directory";
            this.button_Directory.UseVisualStyleBackColor = true;
            this.button_Directory.Click += new System.EventHandler(this.button_Directory_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(608, 294);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 81);
            this.button4.TabIndex = 5;
            this.button4.Text = "Notes";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.Location = new System.Drawing.Point(12, 362);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(40, 16);
            this.label_Time.TabIndex = 8;
            this.label_Time.Text = "clock";
            // 
            // timer_SystemTime
            // 
            this.timer_SystemTime.Enabled = true;
            this.timer_SystemTime.Interval = 1000;
            this.timer_SystemTime.Tick += new System.EventHandler(this.timer_SystemTime_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.ControlBox = false;
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_Directory);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_Attendance);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "City on a Hill Console";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button_Attendance;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button_Directory;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donationHistoryToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donationRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Timer timer_SystemTime;
    }
}


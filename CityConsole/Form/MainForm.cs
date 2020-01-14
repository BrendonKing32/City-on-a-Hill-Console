using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityConsole
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CITY ON A HILL CONSOLE" + "\nBRENDON KING 2020");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        //Function  :
        //Purpose   :
        //Parameters:
        //Returns   :
        private void button_Attendance_Click(object sender, EventArgs e)
        {
            ShowAttendance ShowForm = new ShowAttendance();
            ShowForm.Show();
        }

        private void button_Directory_Click(object sender, EventArgs e)
        {
            
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDirectoryForm directoryForm = new NewDirectoryForm();
            directoryForm.ShowDialog();
        }

        private void attendanceRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttendanceForm attendanceForm = new AttendanceForm();
            attendanceForm.ShowDialog();
        }

        private void noteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer_SystemTime_Tick(object sender, EventArgs e)
        {
            label_Time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void button_UpdateAttendance_Click(object sender, EventArgs e)
        {
            attendanceRecordToolStripMenuItem_Click(sender, e);
        }

        private void button_UpdateDirectory_Click(object sender, EventArgs e)
        {
            memberToolStripMenuItem_Click(sender, e);
        }
    }
}

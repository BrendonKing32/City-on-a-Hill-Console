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
    public partial class AttendanceForm : Form
    {
        public AttendanceForm()
        {
            InitializeComponent();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            int adultCount = System.Convert.ToInt32(textBox_Adults.Text);
            int childCount = System.Convert.ToInt32(textBox_Children.Text);

            CityonaHillDataSetTableAdapters.AttendanceTableAdapter attendance = new CityonaHillDataSetTableAdapters.AttendanceTableAdapter();
            attendance.Insert(dateTimePicker1.Value, adultCount, childCount, comboBox_Notes.Text);

            MessageBox.Show("Attendance Recorded!");
            this.Close();
        }
    }
}

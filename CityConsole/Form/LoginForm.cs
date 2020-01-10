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
    public partial class LoginForm : Form
    {
        string adminPass = "John3:16";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button_Cont_Click(object sender, EventArgs e)
        {
            string checkPass = adminPass;
            string passConfirm = textBox_password.Text;
            if (checkPass == passConfirm)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("PASSWORD INCORRECT");
            }
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                string checkPass = adminPass;
                string passConfirm = textBox_password.Text;
                if (checkPass == passConfirm)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("PASSWORD INCORRECT");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Garden_Group
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_forgot_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_employee_Click(object sender, EventArgs e)
        {

            if (txt_username_employee.Text == "" || txt_username_subject.Text == "")
            {
                MessageBox.Show("Please enter your username and password!");
            }

            if (true)
            {
                ServiceDesk Desk = new ServiceDesk();
                Desk.ShowDialog();
            }
            /*else if (txt_username_subject.Text == true)
            {

            }*/

            
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceDeskModel;
using ServiceDeskController;

namespace The_Garden_Group
{
    public partial class EditAddUser : Form
    {
        public EditAddUser()
        {
            InitializeComponent();
        }

        private string id;
        User_Service service = new User_Service();


        public void EditExistingUser(ServiceDeskModel.User u)
        {
            txtFirstName.Text = u.firstName;
            txtLastName.Text = u.lastName;
            txtEmail.Text = u.email;
            txtPhone.Text = u.phone.ToString();
            comboLocation.SelectedItem = u.location;
            comboType.SelectedItem = u.type;
            Show();
        }

        internal void AddNewUser()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            comboLocation.SelectedItem = "Haarlem";
            comboType.SelectedItem = "employee";
            Show();
        }

        public User GetUser()
        {
            User user = new User()
            {
                firstName = txtFirstName.Text,
                lastName = txtLastName.Text,
                phone = int.Parse(txtPhone.Text),
                location = comboLocation.Text,
                email = txtEmail.Text,
                type = comboType.Text
            };
            return user;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = GetUser();

            if (service.Exists(user.phone))
            {
                service.UpdateUser(user);
            }
            else
            {
                service.InsertUser(user);
            }

            
            OverviewUsers overview = new OverviewUsers();
            overview.Show();
            this.Hide();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OverviewUsers overviewUsers = new OverviewUsers();
            overviewUsers.Show();
            this.Hide();
        }
    }
}

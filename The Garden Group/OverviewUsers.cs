using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ServiceDeskController;
using ServiceDeskModel;

namespace The_Garden_Group
{
    public partial class OverviewUsers : Form
    {
        public OverviewUsers()
        {
            InitializeComponent();
            
            List<ServiceDeskModel.User> users = service.listUsers();

            showUsers(users);
        }

        User_Service service = new User_Service();
        EditAddUser editForm = new EditAddUser();
        public Action<string> onDelete;

        public void showUsers(List<ServiceDeskModel.User> users)
        {
            flowLayoutPanelShowUsers.Controls.Clear();

            foreach (var item in users)
            {
                var ul = new UserLine();
                ul.SetItem(item);
                ul.onEdit = DoEdit;
                ul.onDelete = DoDelete;
                flowLayoutPanelShowUsers.Controls.Add(ul);
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            editForm.AddNewUser();
            this.Hide();
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide(); 
        }

        private void DoEdit(UserLine ul)
        {
            var user = ul.GetItem();
            editForm.EditExistingUser(user);
            this.Hide();
        }

        private void DoDelete(UserLine ul)
        {
            var user = ul.GetItem();
            var result = MessageBox.Show("Are you sure you want to delete "+ user.firstName +"'s account?", "Delete User",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                service.DeleteUser(user._id);
                OverviewUsers overview = new OverviewUsers();
                overview.Show();
                this.Hide();
            }

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            List<User> users = service.listUsers();
            List<User> SearchResults = new List<User>();

            foreach (User row in users)
            {
                if (row.email == searchbox.Text)
                {
                    SearchResults.Add(row);
                }

            }

            if (SearchResults.Count > 0)
            {
                showUsers(SearchResults);

            }
            else if (searchbox.Text == "")
            {
                showUsers(users);
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }

        public void ShowTickets(List<User> users)
        {
            flowLayoutPanelShowUsers.Controls.Clear();

            foreach (var item in users)
            {
                var ul = new UserLine();
                ul.SetItem(item);
                ul.onEdit = DoEdit;
                ul.onDelete = DoDelete;
                flowLayoutPanelShowUsers.Controls.Add(ul);
            }
        }
        
    }
}


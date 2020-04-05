using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceDeskModel;

namespace The_Garden_Group
{
    public partial class UserLine : UserControl
    {
        public UserLine()
        {
            InitializeComponent();
        }
        public Action<UserLine> onEdit { get; set; }
        public Action<UserLine> onDelete { get; set; }

        private User user;

        public void SetItem(ServiceDeskModel.User u)
        {
            user = u;
            lblID.Text = u._id.ToString();
            lblEmail.Text = u.email;
            lblFirstName.Text = u.firstName;
            lblLastName.Text = u.lastName;
            lblTickets.Text = "1";
        }

        public User GetItem()
        {
            return user;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (onEdit != null)
            {
                onEdit(this);
            }
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            if (onEdit != null)
            {
                onDelete(this);
            }
        }

    }
}

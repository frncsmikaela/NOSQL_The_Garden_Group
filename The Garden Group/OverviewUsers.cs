using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceDeskController;

namespace The_Garden_Group
{
    public partial class OverviewUsers : Form
    {
        public OverviewUsers()
        {
            InitializeComponent();

            User_Service service = new User_Service();
            List<ServiceDeskModel.User> users = service.listUsers();

            showUsers(users);
        }

        EditAddUser editForm;
        public Action<string> onDelete;

        public void showUsers(List<ServiceDeskModel.User> users)
        {
            // flowlayoutpanel clear
            flowLayoutPanelShowUsers.Controls.Clear();

            foreach (var item in users)
            {
                var vl = new UserLine();
                vl.SetItem(item);
                //vl.onEdit = DoEdit;
                //vl.onDelete = DoDelete;
                flowLayoutPanelShowUsers.Controls.Add(vl);
            }
        }
    }
}

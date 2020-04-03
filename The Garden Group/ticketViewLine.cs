using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ServiceDeskController.Incident_Service;

namespace The_Garden_Group
{
    public partial class TicketViewLine : UserControl
    {
        public Action<TicketViewLine> onEdit { get; set; }
        public Action<TicketViewLine> onDelete { get; set; }
        private ViewIncident viewIncident;
        public TicketViewLine()
        {
            InitializeComponent();
        }

        public void SetItem(ViewIncident i)
        {
            viewIncident = i;
            lblID.Text = i.id;
            lblSubjectEmail.Text = i.subjectEmail;
            lblEmployeeID.Text = i.employeeID.ToString();
            lblDateCreated.Text = i.dateCreated.ToString();
            lblStatus.Text = i.status;
        }

        public ViewIncident GetItem()
        {
            return viewIncident;
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

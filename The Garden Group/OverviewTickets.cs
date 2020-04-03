using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ServiceDeskController.Incident_Service;
using ServiceDeskController;

namespace The_Garden_Group
{
    public partial class OverviewTickets : Form
    {
        EditAddForm editForm;
        public Action<string> onDelete;
        public OverviewTickets()
        {
            InitializeComponent();
            FormClosing += (s, e) => { this.Hide(); e.Cancel = true; };
        }

        internal  void SetEditForm(EditAddForm edit)
        {
            this.editForm = edit;
        }

        // Copies all elements in the given list to the ticket view
        // A view line for every is created
        // Each view line is added to the list
        public void showTickets(List<ViewIncident> incidents)
        {
            // flowlayoutpanel clear
            flowLayoutPanelShowTickets.Controls.Clear();

            foreach (var item in incidents)
            {
                var vl = new TicketViewLine();
                vl.SetItem(item);
                vl.onEdit = DoEdit;
                vl.onDelete = DoDelete;
                flowLayoutPanelShowTickets.Controls.Add(vl);
            }
        }

        private void DoEdit(TicketViewLine vl)
        {
            var item = vl.GetItem();
            editForm.EditExistingItem(item);
        }

        private void DoDelete(TicketViewLine vl)
        {
            var item = vl.GetItem();
            var result = MessageBox.Show("Are you sure you want to delete this ticket?", "Delete Ticket",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.OK)
            {
                // delete ticket 
                onDelete(item.id);
                
            }
        }

        private void CheckDateDeadline(TicketViewLine vl)
        {
            var item = vl.GetItem();

            if (item.dateDeadline > DateTime.Now)
            {
                item.status = "PastDeadline";
            }
        }
    }
}


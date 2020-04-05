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
    public partial class Dashboard : Form
    {
        private Incident_Service incidentService = new Incident_Service();
        private OverviewTickets overviewForm = new OverviewTickets();
        private EditAddForm editForm = new EditAddForm();
        private string filter = null;

        public Dashboard()
        {
            InitializeComponent();
            UpdateDashboardUI();
            editForm.onSave = DoSave;
            editForm.onAdd = DoAdd;
            overviewForm.onDelete = DoDelete;

            overviewForm.SetEditForm(editForm);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Updates the complete UI of the Dashboard and all forms
        private void UpdateDashboardUI()
        {
            int beforeDeadline = incidentService.CountUnresolvedIncidents("BeforeDeadline");
            int pastDeadlineIncidents = incidentService.CountUnresolvedIncidents("PastDeadline");
            int allIncidents = incidentService.countAllIncidents();
            lblUnresolvedTickets.Text = beforeDeadline.ToString();
            lblPastDeadline.Text = pastDeadlineIncidents.ToString();
            lblAllTickets.Text = allIncidents.ToString();
        }

        private void panel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           

        }

        private void pnlUnresolvedTickets_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnlUnresolvedTickets_MouseClick(object sender, MouseEventArgs e)
        {
            overviewForm.heading = "Unresolved Tickets";
            filter = "BeforeDeadline";
            UpdateIncidents();
            this.Hide();
            overviewForm.Show();
        }

        private void pnlPastDeadlinesTickets_MouseClick(object sender, MouseEventArgs e)
        {
            overviewForm.heading = "Tickets Past Deadline";
            filter = "PastDeadline";
            UpdateIncidents();
            this.Hide();
            overviewForm.Show();
        }

        // Updates the overview tickets list UI.
        private void UpdateIncidents()
        {
            List<Incident_Service.ViewIncident> incidents;
            if (filter != null)
            {
                // Retrieve the list of incidents
                incidents = incidentService.listIncidents(filter);
            }
            else
            {
                incidents = incidentService.listIncidents();
            }
            // Put the items into the form
            overviewForm.showTickets(incidents);
        }

        private void pnlAllTickets_MouseClick(object sender, MouseEventArgs e)
        {
            overviewForm.heading = "All Tickets";
            filter = null;
            UpdateIncidents();
            this.Hide();
            overviewForm.Show();
        }

        // Show the edit form to edit a NEW item.
        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            editForm.EditNewItem();
        }
        private void DoSave(Incident_Service.ViewIncident incident)
        {
            incidentService.UpdateTicket(incident);
            // Refresh list
            // I need to know: which "filter" (unresolved, past deadline, ...) is used
            UpdateIncidents();
            UpdateDashboardUI();
        }

        private void DoAdd(Incident_Service.ViewIncident incident)
        {
            incidentService.InsertTicket(incident);
            UpdateIncidents();
            UpdateDashboardUI();
        }

        private void DoDelete(string id)
        {
            //call the incident service delete ticket
            incidentService.DeleteTicket(id);
            UpdateIncidents();
            UpdateDashboardUI();
        }

        private void pnlPastDeadlinesTickets_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OverviewUsers overviewUsers = new OverviewUsers();
            overviewUsers.Show();
            this.Hide();
        }
    }
}

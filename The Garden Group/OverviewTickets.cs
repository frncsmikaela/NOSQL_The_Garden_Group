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
using System.Text.RegularExpressions;

namespace The_Garden_Group
{
    // New check in, reverted
    public partial class OverviewTickets : Form
    {
        EditAddForm editForm;
        public Action<string> onDelete;
        List<ViewIncident> incidents;
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
        // A view line for every element is created
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
        private void PlaceholderTxt()
        {
            searchbx.Text = "Email or Id";
            searchbx.ForeColor = Color.Gray;
        }

        private void searchbx_Click(object sender, EventArgs e)
        {
            if (searchbx.Text == "Email or Id")
            {
                searchbx.Text = "";
                searchbx.ForeColor = Color.Black;

            }
        }

        private void searchbx_Leave(object sender, EventArgs e)
        {
            if (searchbx.Text == "")
            {
                PlaceholderTxt();

            }
        }
        // validate email address
        private bool IsValidEmail(string email)
        {
            try
            {
                email = email.Trim();
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            bool email = IsValidEmail(searchbx.Text);
            bool ticketId = IsAlphanumeric(searchbx.Text);
            bool customerId = IsInt(searchbx.Text);

            if (searchbx.Text != "Email or Id")
            {
                if (email || ticketId || customerId )
                {
                    Incident_Service incidentService = new Incident_Service();
                     incidents = incidentService.listIncidents();
                    List<ViewIncident> SearchResults = new List<ViewIncident>();

                    foreach (var row in incidents)
                    {
                            if (row.subjectEmail == searchbx.Text || row.id == searchbx.Text || row.employeeID.ToString() == searchbx.Text)
                            {
                                // add search results to list
                               SearchResults.Add(row);
                            }
                        
                    }
                    // check if any results have been added to list
                    if (SearchResults.Count > 0)
                    {
                        showTickets(SearchResults);

                    }
                    else
                    {
                        MessageBox.Show("Ticket not found");
                    }

                }
                else
                {
                    MessageBox.Show("Enter a valid email or Id");
                }
            }
            else
            {
                MessageBox.Show("Search box is empty");
            }
        }
        private void OverviewTickets_Click(object sender, EventArgs e)
        {
            showTickets(incidents);
            PlaceholderTxt();
        }
        private bool IsAlphanumeric(string str)
        {
            if (Regex.IsMatch(str, "^[a-zA-Z0-9]*$"))
            {
                return true;
            }
            return false;
        }
        private bool IsInt(string str)
        {
            if (str.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }
    }
}


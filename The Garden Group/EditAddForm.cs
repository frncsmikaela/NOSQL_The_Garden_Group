using ServiceDeskController;
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

namespace The_Garden_Group
{
    public partial class EditAddForm : Form
    {
        private string id;
        private int subjectID;
        public Action<ViewIncident> onSave { get; set; }
        public Action<ViewIncident> onAdd { get; set; }
        private email mail;
        private string status;


        public EditAddForm()
        {
            InitializeComponent();
            FormClosing += (s, e) => { this.Hide(); e.Cancel = true; };
        }

        internal void EditNewItem()
        {
            // TODO clear all fields and enable/disable button

            txtBoxSubjectEmail.Text = "";
            txtDescription.Text = "";
            txtBoxEmployeeID.Text = "";
            comboBoxStatus.Text = "Unresolved";
            dateTimePickerDateDeadline.Value = DateTime.Now;
            btnSaveChanges.Enabled = false;
            btnAddTicket.Enabled = true;
            Show();
        }

        public void EditExistingItem(ViewIncident i )
        {
            txtBoxSubjectEmail.Text = i.subjectEmail;
            dateTimePickerDateDeadline.Value = i.dateDeadline;
            txtDescription.Text = i.problemDescription;
            txtBoxEmployeeID.Text = i.employeeID.ToString();
            comboBoxStatus.Text = i.status;
            status = i.status;
            this.id = i.id;
            this.subjectID = i.subjectID;
            btnAddTicket.Enabled = false;
            btnSaveChanges.Enabled = true;
            Show();
        }

        public ViewIncident GetItem()
        {
            ViewIncident newValue = new ViewIncident();
            newValue.subjectEmail = txtBoxSubjectEmail.Text;
            newValue.status = comboBoxStatus.Text;
            newValue.problemDescription = txtDescription.Text;
            newValue.dateDeadline = dateTimePickerDateDeadline.Value;
            newValue.employeeID = int.Parse(txtBoxEmployeeID.Text);
            newValue.id = id;
            newValue.subjectID = subjectID;
            return newValue;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)

        {
            if (IsListCorrect())
            {
                mail = new email();
                onSave(GetItem());
                
                if(status != comboBoxStatus.Text)// check is status has been updated
                {
                    mail.ProblemResolved(txtBoxSubjectEmail.Text); // send email to infrom customer(problem solved)

                }
                this.Hide();
            }
            
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            if (IsListCorrect())
            {
                mail = new email();
                onAdd(GetItem());
                mail.IncidentBooked(txtBoxSubjectEmail.Text); // send cofirmation email
                this.Hide();
            }
        }

        private bool IsListCorrect()
        {
            // This is a list of all empty field nameds
            var emptyFields = new List<string>();

            if (txtBoxSubjectEmail.Text == string.Empty)
                emptyFields.Add("Subject Email");
            if (txtDescription.Text == string.Empty)
                emptyFields.Add("Problem Description");
            if (txtBoxEmployeeID.Text == string.Empty)
                emptyFields.Add("Employee ID");

            // Check if all is OK.
            // If not: show a dialog
            // If correct: add the item
            var correct = (emptyFields.Count == 0);
            if (!correct)
            {
                MessageBox.Show("Please enter " + String.Join(",", emptyFields));
            }
            return correct;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

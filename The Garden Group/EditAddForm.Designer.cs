namespace The_Garden_Group
{
    partial class EditAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlEditAddForm = new System.Windows.Forms.Panel();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateCreated = new System.Windows.Forms.DateTimePicker();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxSubjectEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlEditAddForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEditAddForm
            // 
            this.pnlEditAddForm.Controls.Add(this.btnGoBack);
            this.pnlEditAddForm.Controls.Add(this.groupBox1);
            this.pnlEditAddForm.Controls.Add(this.txtBoxEmployeeID);
            this.pnlEditAddForm.Controls.Add(this.label2);
            this.pnlEditAddForm.Location = new System.Drawing.Point(12, 115);
            this.pnlEditAddForm.Name = "pnlEditAddForm";
            this.pnlEditAddForm.Size = new System.Drawing.Size(808, 553);
            this.pnlEditAddForm.TabIndex = 2;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoBack.Location = new System.Drawing.Point(690, 487);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(104, 53);
            this.btnGoBack.TabIndex = 8;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxStatus);
            this.groupBox1.Controls.Add(this.dateTimePickerDateCreated);
            this.groupBox1.Controls.Add(this.btnAddTicket);
            this.groupBox1.Controls.Add(this.btnSaveChanges);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxSubjectEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 488);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket Info";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DisplayMember = "Unresolved";
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Unresolved",
            "PastDeadline",
            "Completed"});
            this.comboBoxStatus.Location = new System.Drawing.Point(136, 113);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(200, 24);
            this.comboBoxStatus.TabIndex = 9;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePickerDateCreated
            // 
            this.dateTimePickerDateCreated.CustomFormat = "MMMM dd, yyyy-dddd";
            this.dateTimePickerDateCreated.Location = new System.Drawing.Point(117, 166);
            this.dateTimePickerDateCreated.Name = "dateTimePickerDateCreated";
            this.dateTimePickerDateCreated.Size = new System.Drawing.Size(248, 22);
            this.dateTimePickerDateCreated.TabIndex = 9;
            this.dateTimePickerDateCreated.Value = new System.DateTime(2020, 3, 30, 15, 43, 15, 0);
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTicket.Location = new System.Drawing.Point(261, 429);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(104, 53);
            this.btnAddTicket.TabIndex = 7;
            this.btnAddTicket.Text = "Add Ticket";
            this.btnAddTicket.UseVisualStyleBackColor = true;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.Location = new System.Drawing.Point(10, 429);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(104, 53);
            this.btnSaveChanges.TabIndex = 5;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(136, 232);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 161);
            this.txtDescription.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // txtBoxSubjectEmail
            // 
            this.txtBoxSubjectEmail.Location = new System.Drawing.Point(136, 55);
            this.txtBoxSubjectEmail.Name = "txtBoxSubjectEmail";
            this.txtBoxSubjectEmail.Size = new System.Drawing.Size(200, 22);
            this.txtBoxSubjectEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Email";
            // 
            // txtBoxEmployeeID
            // 
            this.txtBoxEmployeeID.Location = new System.Drawing.Point(488, 71);
            this.txtBoxEmployeeID.Name = "txtBoxEmployeeID";
            this.txtBoxEmployeeID.Size = new System.Drawing.Size(200, 22);
            this.txtBoxEmployeeID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID";
            // 
            // EditAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 693);
            this.Controls.Add(this.pnlEditAddForm);
            this.Name = "EditAddForm";
            this.Text = "EditAddForm";
            this.pnlEditAddForm.ResumeLayout(false);
            this.pnlEditAddForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEditAddForm;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxSubjectEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxEmployeeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateCreated;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}
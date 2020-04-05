namespace The_Garden_Group
{
    partial class UserLine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTickets = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickets.Location = new System.Drawing.Point(616, 17);
            this.lblTickets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(46, 17);
            this.lblTickets.TabIndex = 13;
            this.lblTickets.Text = "label1";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(490, 17);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(46, 17);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "label1";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(389, 17);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(46, 17);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "label1";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(205, 17);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "label1";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(8, 17);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(46, 17);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "label1";
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDelete.Image = global::The_Garden_Group.Properties.Resources.delete;
            this.pictureBoxDelete.Location = new System.Drawing.Point(730, 8);
            this.pictureBoxDelete.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(38, 31);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDelete.TabIndex = 15;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBoxDelete_Click);
            // 
            // pictureBoxEdit
            // 
            this.pictureBoxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEdit.Image = global::The_Garden_Group.Properties.Resources.edit;
            this.pictureBoxEdit.Location = new System.Drawing.Point(685, 8);
            this.pictureBoxEdit.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(34, 30);
            this.pictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEdit.TabIndex = 14;
            this.pictureBoxEdit.TabStop = false;
            this.pictureBoxEdit.Click += new System.EventHandler(this.pictureBoxEdit_Click);
            // 
            // UserLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxDelete);
            this.Controls.Add(this.pictureBoxEdit);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblID);
            this.Name = "UserLine";
            this.Size = new System.Drawing.Size(776, 46);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.PictureBox pictureBoxEdit;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblID;
    }
}

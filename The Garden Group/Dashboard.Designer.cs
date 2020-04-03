namespace The_Garden_Group
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUnresolvedTickets = new System.Windows.Forms.Panel();
            this.lblUnresolvedTickets = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlPastDeadlinesTickets = new System.Windows.Forms.Panel();
            this.lblPastDeadline = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAllTickets = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlAllTickets = new System.Windows.Forms.Panel();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlUnresolvedTickets.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlPastDeadlinesTickets.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlAllTickets.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlUnresolvedTickets);
            this.panel1.Location = new System.Drawing.Point(31, 155);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(324, 297);
            this.panel1.TabIndex = 3;
            // 
            // pnlUnresolvedTickets
            // 
            this.pnlUnresolvedTickets.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUnresolvedTickets.Controls.Add(this.lblUnresolvedTickets);
            this.pnlUnresolvedTickets.Controls.Add(this.label2);
            this.pnlUnresolvedTickets.Controls.Add(this.label1);
            this.pnlUnresolvedTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlUnresolvedTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUnresolvedTickets.Location = new System.Drawing.Point(4, 4);
            this.pnlUnresolvedTickets.Name = "pnlUnresolvedTickets";
            this.pnlUnresolvedTickets.Size = new System.Drawing.Size(314, 287);
            this.pnlUnresolvedTickets.TabIndex = 1;
            this.pnlUnresolvedTickets.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUnresolvedTickets_Paint);
            this.pnlUnresolvedTickets.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlUnresolvedTickets_MouseClick);
            this.pnlUnresolvedTickets.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDoubleClick);
            // 
            // lblUnresolvedTickets
            // 
            this.lblUnresolvedTickets.AutoSize = true;
            this.lblUnresolvedTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnresolvedTickets.Location = new System.Drawing.Point(77, 136);
            this.lblUnresolvedTickets.Name = "lblUnresolvedTickets";
            this.lblUnresolvedTickets.Size = new System.Drawing.Size(158, 55);
            this.lblUnresolvedTickets.TabIndex = 3;
            this.lblUnresolvedTickets.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "All tickets currently open";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unresolved Tickets";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.pnlPastDeadlinesTickets);
            this.panel3.Location = new System.Drawing.Point(528, 155);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(327, 297);
            this.panel3.TabIndex = 4;
            // 
            // pnlPastDeadlinesTickets
            // 
            this.pnlPastDeadlinesTickets.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPastDeadlinesTickets.Controls.Add(this.lblPastDeadline);
            this.pnlPastDeadlinesTickets.Controls.Add(this.label4);
            this.pnlPastDeadlinesTickets.Controls.Add(this.label3);
            this.pnlPastDeadlinesTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlPastDeadlinesTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPastDeadlinesTickets.Location = new System.Drawing.Point(4, 4);
            this.pnlPastDeadlinesTickets.Name = "pnlPastDeadlinesTickets";
            this.pnlPastDeadlinesTickets.Size = new System.Drawing.Size(319, 289);
            this.pnlPastDeadlinesTickets.TabIndex = 0;
            this.pnlPastDeadlinesTickets.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlPastDeadlinesTickets_MouseClick);
            // 
            // lblPastDeadline
            // 
            this.lblPastDeadline.AutoSize = true;
            this.lblPastDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastDeadline.Location = new System.Drawing.Point(81, 137);
            this.lblPastDeadline.Name = "lblPastDeadline";
            this.lblPastDeadline.Size = new System.Drawing.Size(158, 55);
            this.lblPastDeadline.TabIndex = 4;
            this.lblPastDeadline.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "These tickets needs your \r\nimmediate attention";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Incidents Past Deadline";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.pnlAllTickets);
            this.panel5.Location = new System.Drawing.Point(226, 485);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(4);
            this.panel5.Size = new System.Drawing.Size(319, 287);
            this.panel5.TabIndex = 5;
            // 
            // lblAllTickets
            // 
            this.lblAllTickets.AutoSize = true;
            this.lblAllTickets.BackColor = System.Drawing.SystemColors.Control;
            this.lblAllTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTickets.Location = new System.Drawing.Point(81, 120);
            this.lblAllTickets.Name = "lblAllTickets";
            this.lblAllTickets.Size = new System.Drawing.Size(158, 55);
            this.lblAllTickets.TabIndex = 5;
            this.lblAllTickets.Text = "label3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "List of all tickets ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(86, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "All Tickets";
            // 
            // pnlAllTickets
            // 
            this.pnlAllTickets.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAllTickets.Controls.Add(this.lblAllTickets);
            this.pnlAllTickets.Controls.Add(this.label5);
            this.pnlAllTickets.Controls.Add(this.label6);
            this.pnlAllTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAllTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAllTickets.Location = new System.Drawing.Point(4, 4);
            this.pnlAllTickets.Name = "pnlAllTickets";
            this.pnlAllTickets.Size = new System.Drawing.Size(311, 279);
            this.pnlAllTickets.TabIndex = 0;
            this.pnlAllTickets.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlAllTickets_MouseClick);
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateTicket.Location = new System.Drawing.Point(740, 80);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(144, 57);
            this.btnCreateTicket.TabIndex = 6;
            this.btnCreateTicket.Text = "Create Ticket";
            this.btnCreateTicket.UseVisualStyleBackColor = true;
            this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateTicket_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 802);
            this.Controls.Add(this.btnCreateTicket);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.pnlUnresolvedTickets.ResumeLayout(false);
            this.pnlUnresolvedTickets.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlPastDeadlinesTickets.ResumeLayout(false);
            this.pnlPastDeadlinesTickets.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.pnlAllTickets.ResumeLayout(false);
            this.pnlAllTickets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlUnresolvedTickets;
        private System.Windows.Forms.Label lblUnresolvedTickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlPastDeadlinesTickets;
        private System.Windows.Forms.Label lblPastDeadline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlAllTickets;
        private System.Windows.Forms.Label lblAllTickets;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateTicket;
    }
}


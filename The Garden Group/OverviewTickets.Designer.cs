namespace The_Garden_Group
{
    partial class OverviewTickets
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
            this.flowLayoutPanelShowTickets = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchbx = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelShowTickets
            // 
            this.flowLayoutPanelShowTickets.AutoScroll = true;
            this.flowLayoutPanelShowTickets.Location = new System.Drawing.Point(12, 190);
            this.flowLayoutPanelShowTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelShowTickets.Name = "flowLayoutPanelShowTickets";
            this.flowLayoutPanelShowTickets.Size = new System.Drawing.Size(1091, 598);
            this.flowLayoutPanelShowTickets.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(499, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee \r\nID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(627, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date Deadline";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(820, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Status";
            // 
            // searchbx
            // 
            this.searchbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbx.ForeColor = System.Drawing.Color.Gray;
            this.searchbx.Location = new System.Drawing.Point(395, 66);
            this.searchbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchbx.Name = "searchbx";
            this.searchbx.Size = new System.Drawing.Size(225, 24);
            this.searchbx.TabIndex = 7;
            this.searchbx.Text = "Email or Id";
            this.searchbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchbx.Click += new System.EventHandler(this.searchbx_Click);
            this.searchbx.Leave += new System.EventHandler(this.searchbx_Leave);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(632, 66);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(143, 28);
            this.searchbtn.TabIndex = 8;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // OverviewTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 799);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelShowTickets);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OverviewTickets";
            this.Text = "OverviewTickets";
            this.Click += new System.EventHandler(this.OverviewTickets_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelShowTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchbx;
        private System.Windows.Forms.Button searchbtn;
    }
}
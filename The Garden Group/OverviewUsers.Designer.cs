namespace The_Garden_Group
{
    partial class OverviewUsers
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
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelShowUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.dashboardbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(477, 31);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(107, 23);
            this.searchbtn.TabIndex = 16;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.ForeColor = System.Drawing.Color.Gray;
            this.searchbox.Location = new System.Drawing.Point(299, 31);
            this.searchbox.Name = "searchbox";
            this.searchbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.searchbox.Size = new System.Drawing.Size(170, 21);
            this.searchbox.TabIndex = 15;
            this.searchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(489, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "First Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // flowLayoutPanelShowUsers
            // 
            this.flowLayoutPanelShowUsers.AutoScroll = true;
            this.flowLayoutPanelShowUsers.Location = new System.Drawing.Point(12, 131);
            this.flowLayoutPanelShowUsers.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelShowUsers.Name = "flowLayoutPanelShowUsers";
            this.flowLayoutPanelShowUsers.Size = new System.Drawing.Size(818, 486);
            this.flowLayoutPanelShowUsers.TabIndex = 9;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateUser.Location = new System.Drawing.Point(723, 79);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(108, 38);
            this.btnCreateUser.TabIndex = 17;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // dashboardbtn
            // 
            this.dashboardbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardbtn.Location = new System.Drawing.Point(729, 12);
            this.dashboardbtn.Name = "dashboardbtn";
            this.dashboardbtn.Size = new System.Drawing.Size(101, 24);
            this.dashboardbtn.TabIndex = 18;
            this.dashboardbtn.Text = "Dashboard";
            this.dashboardbtn.UseVisualStyleBackColor = true;
            this.dashboardbtn.Click += new System.EventHandler(this.dashboardbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Email:";
            // 
            // OverviewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 649);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dashboardbtn);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelShowUsers);
            this.Name = "OverviewUsers";
            this.Text = "OverviewUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelShowUsers;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button dashboardbtn;
        private System.Windows.Forms.Label label6;
    }
}
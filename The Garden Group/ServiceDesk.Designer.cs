namespace The_Garden_Group
{
    partial class ServiceDesk
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
            this.lbl_datetime = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_languages = new System.Windows.Forms.ComboBox();
            this.lbl_languages = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_datetime
            // 
            this.lbl_datetime.AutoSize = true;
            this.lbl_datetime.Location = new System.Drawing.Point(21, 66);
            this.lbl_datetime.Name = "lbl_datetime";
            this.lbl_datetime.Size = new System.Drawing.Size(64, 17);
            this.lbl_datetime.TabIndex = 5;
            this.lbl_datetime.Text = "00:00:00";
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(24, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(127, 39);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustrip,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 92);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(158, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menustrip
            // 
            this.menustrip.Name = "menustrip";
            this.menustrip.Size = new System.Drawing.Size(94, 24);
            this.menustrip.Text = "Dashboard";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // cmb_languages
            // 
            this.cmb_languages.FormattingEnabled = true;
            this.cmb_languages.Items.AddRange(new object[] {
            "English",
            "Dutch"});
            this.cmb_languages.Location = new System.Drawing.Point(606, 40);
            this.cmb_languages.Name = "cmb_languages";
            this.cmb_languages.Size = new System.Drawing.Size(121, 24);
            this.cmb_languages.TabIndex = 6;
            // 
            // lbl_languages
            // 
            this.lbl_languages.AutoSize = true;
            this.lbl_languages.Location = new System.Drawing.Point(603, 12);
            this.lbl_languages.Name = "lbl_languages";
            this.lbl_languages.Size = new System.Drawing.Size(79, 17);
            this.lbl_languages.TabIndex = 7;
            this.lbl_languages.Text = "Languages";
            this.lbl_languages.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // ServiceDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 536);
            this.Controls.Add(this.lbl_languages);
            this.Controls.Add(this.cmb_languages);
            this.Controls.Add(this.lbl_datetime);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ServiceDesk";
            this.Text = "ServiceDesk";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_datetime;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menustrip;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmb_languages;
        private System.Windows.Forms.Label lbl_languages;
    }
}
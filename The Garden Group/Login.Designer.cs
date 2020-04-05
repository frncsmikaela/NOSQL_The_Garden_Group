namespace The_Garden_Group
{
    partial class Login
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
            this.txt_username_employee = new System.Windows.Forms.TextBox();
            this.txt_username_subject = new System.Windows.Forms.TextBox();
            this.txt_password_employee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_login_employee = new System.Windows.Forms.Button();
            this.btn_forgot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username_employee
            // 
            this.txt_username_employee.Location = new System.Drawing.Point(514, 196);
            this.txt_username_employee.Name = "txt_username_employee";
            this.txt_username_employee.Size = new System.Drawing.Size(188, 22);
            this.txt_username_employee.TabIndex = 15;
            // 
            // txt_username_subject
            // 
            this.txt_username_subject.Location = new System.Drawing.Point(77, 196);
            this.txt_username_subject.Name = "txt_username_subject";
            this.txt_username_subject.Size = new System.Drawing.Size(188, 22);
            this.txt_username_subject.TabIndex = 16;
            // 
            // txt_password_employee
            // 
            this.txt_password_employee.Location = new System.Drawing.Point(514, 276);
            this.txt_password_employee.Name = "txt_password_employee";
            this.txt_password_employee.Size = new System.Drawing.Size(188, 22);
            this.txt_password_employee.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(74, 164);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(73, 17);
            this.Username.TabIndex = 20;
            this.Username.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Employee";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Subject";
            // 
            // btn_login_employee
            // 
            this.btn_login_employee.Location = new System.Drawing.Point(514, 344);
            this.btn_login_employee.Name = "btn_login_employee";
            this.btn_login_employee.Size = new System.Drawing.Size(188, 39);
            this.btn_login_employee.TabIndex = 23;
            this.btn_login_employee.Text = "Login";
            this.btn_login_employee.UseVisualStyleBackColor = true;
            this.btn_login_employee.Click += new System.EventHandler(this.btn_login_employee_Click);
            // 
            // btn_forgot
            // 
            this.btn_forgot.Location = new System.Drawing.Point(77, 344);
            this.btn_forgot.Name = "btn_forgot";
            this.btn_forgot.Size = new System.Drawing.Size(188, 39);
            this.btn_forgot.TabIndex = 24;
            this.btn_forgot.Text = "Forgot Password";
            this.btn_forgot.UseVisualStyleBackColor = true;
            this.btn_forgot.Click += new System.EventHandler(this.btn_forgot_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_forgot);
            this.Controls.Add(this.btn_login_employee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password_employee);
            this.Controls.Add(this.txt_username_subject);
            this.Controls.Add(this.txt_username_employee);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username_employee;
        private System.Windows.Forms.TextBox txt_username_subject;
        private System.Windows.Forms.TextBox txt_password_employee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_login_employee;
        private System.Windows.Forms.Button btn_forgot;
    }
}
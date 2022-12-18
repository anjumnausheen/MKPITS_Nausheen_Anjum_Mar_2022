namespace Windows_form_project_task
{
    partial class Form1
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
            this.SignUp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCPassword = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.ComboBox();
            this.txtRegister = new System.Windows.Forms.Button();
            this.txtCancel = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.SystemColors.Info;
            this.SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SignUp.Location = new System.Drawing.Point(572, 30);
            this.SignUp.Multiline = true;
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(218, 43);
            this.SignUp.TabIndex = 0;
            this.SignUp.Text = "SignUP";
            this.SignUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SignUp.TextChanged += new System.EventHandler(this.SignUp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(106, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(106, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(106, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mobile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(106, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(101, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(106, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 36);
            this.label6.TabIndex = 6;
            this.label6.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(106, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 36);
            this.label7.TabIndex = 7;
            this.label7.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(97, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 36);
            this.label8.TabIndex = 8;
            this.label8.Text = "UserID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(548, 661);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(260, 29);
            this.label11.TabIndex = 11;
            this.label11.Text = "Already a member ?";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(814, 650);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(140, 51);
            this.txtLogin.TabIndex = 12;
            this.txtLogin.Text = "Login";
            this.txtLogin.UseVisualStyleBackColor = true;
            this.txtLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(416, 107);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.MinimumSize = new System.Drawing.Size(4, 20);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(538, 36);
            this.txtName.TabIndex = 13;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(416, 209);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(5);
            this.txtMobile.MinimumSize = new System.Drawing.Size(4, 20);
            this.txtMobile.Multiline = true;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(538, 42);
            this.txtMobile.TabIndex = 15;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(416, 261);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.MinimumSize = new System.Drawing.Size(4, 20);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(538, 35);
            this.txtPassword.TabIndex = 16;
            // 
            // txtCPassword
            // 
            this.txtCPassword.Location = new System.Drawing.Point(416, 320);
            this.txtCPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtCPassword.MinimumSize = new System.Drawing.Size(4, 20);
            this.txtCPassword.Multiline = true;
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.PasswordChar = '*';
            this.txtCPassword.Size = new System.Drawing.Size(538, 36);
            this.txtCPassword.TabIndex = 19;
            // 
            // txtState
            // 
            this.txtState.FormattingEnabled = true;
            this.txtState.Items.AddRange(new object[] {
            "MH",
            "MP",
            "UP",
            "AP"});
            this.txtState.Location = new System.Drawing.Point(416, 384);
            this.txtState.Margin = new System.Windows.Forms.Padding(5);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(538, 24);
            this.txtState.TabIndex = 20;
            // 
            // txtCity
            // 
            this.txtCity.FormattingEnabled = true;
            this.txtCity.Items.AddRange(new object[] {
            "Ngpur",
            "Pune",
            "Mumbai"});
            this.txtCity.Location = new System.Drawing.Point(416, 437);
            this.txtCity.Margin = new System.Windows.Forms.Padding(5);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(538, 24);
            this.txtCity.TabIndex = 21;
            // 
            // txtRegister
            // 
            this.txtRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegister.Location = new System.Drawing.Point(416, 553);
            this.txtRegister.Name = "txtRegister";
            this.txtRegister.Size = new System.Drawing.Size(158, 53);
            this.txtRegister.TabIndex = 22;
            this.txtRegister.Text = "Register";
            this.txtRegister.UseVisualStyleBackColor = true;
            this.txtRegister.Click += new System.EventHandler(this.txtRegister_Click);
            // 
            // txtCancel
            // 
            this.txtCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancel.Location = new System.Drawing.Point(800, 553);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(154, 53);
            this.txtCancel.TabIndex = 23;
            this.txtCancel.Text = "Cancel";
            this.txtCancel.UseVisualStyleBackColor = true;
            this.txtCancel.Click += new System.EventHandler(this.txtCancel_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(416, 485);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserID.MinimumSize = new System.Drawing.Size(4, 20);
            this.txtUserID.Multiline = true;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(538, 41);
            this.txtUserID.TabIndex = 24;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(416, 160);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.MinimumSize = new System.Drawing.Size(4, 20);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(538, 36);
            this.txtEmail.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1237, 769);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtCancel);
            this.Controls.Add(this.txtRegister);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button txtLogin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCPassword;
        private System.Windows.Forms.ComboBox txtState;
        private System.Windows.Forms.ComboBox txtCity;
        private System.Windows.Forms.Button txtRegister;
        private System.Windows.Forms.Button txtCancel;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtEmail;
    }
}


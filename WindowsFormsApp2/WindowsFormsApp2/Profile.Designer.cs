namespace WindowsFormsApp2
{
    partial class Profile
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
            this.txtYname = new System.Windows.Forms.Label();
            this.txtMbl = new System.Windows.Forms.Label();
            this.txtYpassword = new System.Windows.Forms.Label();
            this.txtYemail = new System.Windows.Forms.Label();
            this.txtYstate = new System.Windows.Forms.Label();
            this.txtYN = new System.Windows.Forms.TextBox();
            this.txtMN = new System.Windows.Forms.TextBox();
            this.txtYP = new System.Windows.Forms.TextBox();
            this.txtYE = new System.Windows.Forms.TextBox();
            this.txtYS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtYname
            // 
            this.txtYname.AutoSize = true;
            this.txtYname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYname.Location = new System.Drawing.Point(72, 60);
            this.txtYname.Name = "txtYname";
            this.txtYname.Size = new System.Drawing.Size(126, 25);
            this.txtYname.TabIndex = 0;
            this.txtYname.Text = "Your name is";
            // 
            // txtMbl
            // 
            this.txtMbl.AutoSize = true;
            this.txtMbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMbl.Location = new System.Drawing.Point(70, 119);
            this.txtMbl.Name = "txtMbl";
            this.txtMbl.Size = new System.Drawing.Size(209, 25);
            this.txtMbl.TabIndex = 1;
            this.txtMbl.Text = "Your Mobile Number is";
            // 
            // txtYpassword
            // 
            this.txtYpassword.AutoSize = true;
            this.txtYpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYpassword.Location = new System.Drawing.Point(70, 183);
            this.txtYpassword.Name = "txtYpassword";
            this.txtYpassword.Size = new System.Drawing.Size(163, 25);
            this.txtYpassword.TabIndex = 2;
            this.txtYpassword.Text = "Your Password is";
            // 
            // txtYemail
            // 
            this.txtYemail.AutoSize = true;
            this.txtYemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYemail.Location = new System.Drawing.Point(70, 246);
            this.txtYemail.Name = "txtYemail";
            this.txtYemail.Size = new System.Drawing.Size(128, 25);
            this.txtYemail.TabIndex = 3;
            this.txtYemail.Text = "Your email is ";
            // 
            // txtYstate
            // 
            this.txtYstate.AutoSize = true;
            this.txtYstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYstate.Location = new System.Drawing.Point(70, 314);
            this.txtYstate.Name = "txtYstate";
            this.txtYstate.Size = new System.Drawing.Size(123, 25);
            this.txtYstate.TabIndex = 4;
            this.txtYstate.Text = "Your State is";
            // 
            // txtYN
            // 
            this.txtYN.Location = new System.Drawing.Point(330, 64);
            this.txtYN.Name = "txtYN";
            this.txtYN.Size = new System.Drawing.Size(205, 22);
            this.txtYN.TabIndex = 5;
            // 
            // txtMN
            // 
            this.txtMN.Location = new System.Drawing.Point(330, 123);
            this.txtMN.Name = "txtMN";
            this.txtMN.Size = new System.Drawing.Size(205, 22);
            this.txtMN.TabIndex = 6;
            // 
            // txtYP
            // 
            this.txtYP.Location = new System.Drawing.Point(330, 187);
            this.txtYP.Name = "txtYP";
            this.txtYP.Size = new System.Drawing.Size(205, 22);
            this.txtYP.TabIndex = 7;
            // 
            // txtYE
            // 
            this.txtYE.Location = new System.Drawing.Point(330, 246);
            this.txtYE.Name = "txtYE";
            this.txtYE.Size = new System.Drawing.Size(205, 22);
            this.txtYE.TabIndex = 8;
            // 
            // txtYS
            // 
            this.txtYS.Location = new System.Drawing.Point(330, 314);
            this.txtYS.Name = "txtYS";
            this.txtYS.Size = new System.Drawing.Size(205, 22);
            this.txtYS.TabIndex = 9;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtYS);
            this.Controls.Add(this.txtYE);
            this.Controls.Add(this.txtYP);
            this.Controls.Add(this.txtMN);
            this.Controls.Add(this.txtYN);
            this.Controls.Add(this.txtYstate);
            this.Controls.Add(this.txtYemail);
            this.Controls.Add(this.txtYpassword);
            this.Controls.Add(this.txtMbl);
            this.Controls.Add(this.txtYname);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtYname;
        private System.Windows.Forms.Label txtMbl;
        private System.Windows.Forms.Label txtYpassword;
        private System.Windows.Forms.Label txtYemail;
        private System.Windows.Forms.Label txtYstate;
        private System.Windows.Forms.TextBox txtYN;
        private System.Windows.Forms.TextBox txtMN;
        private System.Windows.Forms.TextBox txtYP;
        private System.Windows.Forms.TextBox txtYE;
        private System.Windows.Forms.TextBox txtYS;
    }
}
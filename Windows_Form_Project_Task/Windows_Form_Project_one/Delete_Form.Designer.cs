namespace Windows_form_project_task
{
    partial class Delete_Form
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
            this.txtDelete = new System.Windows.Forms.Label();
            this.txtYes = new System.Windows.Forms.Button();
            this.txtNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDelete
            // 
            this.txtDelete.AutoSize = true;
            this.txtDelete.BackColor = System.Drawing.SystemColors.Info;
            this.txtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelete.ForeColor = System.Drawing.Color.Brown;
            this.txtDelete.Location = new System.Drawing.Point(67, 91);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(390, 29);
            this.txtDelete.TabIndex = 0;
            this.txtDelete.Text = "Are You Sure You Want To Delete?";
            // 
            // txtYes
            // 
            this.txtYes.BackColor = System.Drawing.Color.GreenYellow;
            this.txtYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYes.Location = new System.Drawing.Point(88, 147);
            this.txtYes.Name = "txtYes";
            this.txtYes.Size = new System.Drawing.Size(89, 48);
            this.txtYes.TabIndex = 1;
            this.txtYes.Text = "Yes";
            this.txtYes.UseVisualStyleBackColor = false;
            this.txtYes.Click += new System.EventHandler(this.txtYes_Click);
            // 
            // txtNo
            // 
            this.txtNo.BackColor = System.Drawing.Color.GreenYellow;
            this.txtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNo.Location = new System.Drawing.Point(331, 147);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(89, 48);
            this.txtNo.TabIndex = 2;
            this.txtNo.Text = "No";
            this.txtNo.UseVisualStyleBackColor = false;
            this.txtNo.Click += new System.EventHandler(this.txtNo_Click);
            // 
            // Delete_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(486, 372);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.txtYes);
            this.Controls.Add(this.txtDelete);
            this.Name = "Delete_Form";
            this.Text = "Delete_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtDelete;
        private System.Windows.Forms.Button txtYes;
        private System.Windows.Forms.Button txtNo;
    }
}
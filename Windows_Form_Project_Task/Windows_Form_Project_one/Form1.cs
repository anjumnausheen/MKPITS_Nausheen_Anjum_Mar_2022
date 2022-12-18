using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Windows_form_project_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Random generator = new Random();
            String r = generator.Next(0, 1000000).ToString("D6");
            txtUserID.Text = r;
        }

        private void SignUp_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();

            /*Viewall vw = new Viewall();
            vw.Show();*/


        }

        private void txtRegister_Click(object sender, EventArgs e)
        {
            
            string name=txtName.Text;
            string Email=txtEmail.Text;
            string Mobile=txtMobile.Text;
            string Password=txtPassword.Text;
            string ConfirmPasssword=txtCPassword.Text;
            string State=txtState.Text;
            string City=txtCity.Text;
            string UserID = txtUserID.Text;

            string Connstring = "Data Source=LAPTOP-CEIB5MST\\SQLEXPRESS;Initial Catalog=WidowsDB;Integrated Security=True";

            SqlConnection conn = new SqlConnection(Connstring);

           
            try
            {
                conn.Open(); 
                SqlCommand cmd = new SqlCommand("INSERT INTO Windows_Table VALUES('" + name+"', '"+Email+"', '"+Mobile+"','"+Password+"','"+ConfirmPasssword+"','"+State+"','"+City+"','"+UserID+"')", conn);
                int x = cmd.ExecuteNonQuery();
                if(x == 1)
                {
                    MessageBox.Show("REGISTERED SUCCESSFULLY");
                }
                else
                {
                    MessageBox.Show("CANNOT REGISTER..");
                }


            }
            catch(Exception ex)
            {
                Console.WriteLine("Error:"+ex.Message);
                MessageBox.Show(ex.Message);
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

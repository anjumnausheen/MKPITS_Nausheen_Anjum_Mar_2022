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
    public partial class Profile : Form
    {
        public Profile(string name,string Email,string Mobile,string Password,string ConfirmPassword,string state,string city,string UserID)
        {
            InitializeComponent();

            txtBox1.Text = name;
            txtBox2.Text = Email;
            txtBox3.Text = Mobile;
            txtBox4.Text = Password;
            txtBox5.Text = ConfirmPassword;
            comboBox1.Text = state;
            comboBox2.Text = city;
            txtBox8.Text = UserID;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name=txtBox1.Text;
            string email=txtBox2.Text;
            string mobile=txtBox3.Text;
            string password=txtBox4.Text;
            string confirmPassword=txtBox5.Text;
            string state = comboBox1.Text;
            string city = comboBox2.Text;
            string Userid=txtBox8.Text;

            string Connstring = "Data Source=LAPTOP-CEIB5MST\\SQLEXPRESS;Initial Catalog=WidowsDB;Integrated Security=True";

            SqlConnection conn=new SqlConnection(Connstring);
            try
            {
                conn.Open();
                SqlCommand cmd=new SqlCommand("update Windows_Table set name='"+name+"',email='"+email+"',mobile='"+mobile+"',Password='"+password+"',[confirm password]='"+confirmPassword+"',state='"+state+"',city='"+city+ "' where UserID = '"+Userid+"'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("UPDATED RECORD SUCCESSFULLY");                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error:"+ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

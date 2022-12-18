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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userid = txtUserid.Text.Trim();
            String password = txtPassword.Text.Trim();

            if (userid == "admin" && password == "admin")
            {
                Viewall vl = new Viewall();
                vl.Show();
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-CEIB5MST\\SQLEXPRESS;Initial Catalog=WidowsDB;Integrated Security=True");
                string query="Select * from Windows_Table where Userid='"+txtUserid.Text.Trim()+"' and Password='"+txtPassword.Text.Trim()+"'";

                SqlDataAdapter adapter = new SqlDataAdapter(query,conn);
                DataTable dt=new DataTable();
                adapter.Fill(dt);
                if(dt.Rows.Count==1)
                {
                    Profile pf = new Profile(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString());
                    this.Hide();
                    pf.Show();
                }
                else
                {
                    MessageBox.Show("Check Your Username and Password");
                }
            }
         
           


        }
        
        private void txtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

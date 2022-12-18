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
    public partial class Delete_Form : Form
    {
        String userid;
        public Delete_Form(String uid)
        {
            InitializeComponent();
            userid = uid;
        }

        private void txtYes_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-CEIB5MST\\SQLEXPRESS;Initial Catalog=WidowsDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Windows_Table where Userid= '" + userid + "' ", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("DELETED RECORD SUCCESSFULLY");
        }

        private void txtNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

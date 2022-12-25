using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Ado_Dot_Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'widowsDBDataSet.Windows_Table' table. You can move, or remove it, as needed.
            this.windows_TableTableAdapter.Fill(this.widowsDBDataSet.Windows_Table);

            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-CEIB5MST\\SQLEXPRESS;Initial Catalog=WidowsDB;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from Windows_Table", conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();          
            adapter.Fill(dt);
            dataGridView3.DataSource = dt;

        }
    }
}

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

namespace Windows_form_project_task
{
    public partial class Viewall : Form
    {
        public Viewall()
        {
            InitializeComponent();
        }

        private void Viewall_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'widowsDBDataSet.Windows_Table' table. You can move, or remove it, as needed.
            this.windows_TableTableAdapter.Fill(this.widowsDBDataSet.Windows_Table);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rind = e.RowIndex;
            int cind = e.ColumnIndex;
            if(cind == 8)
            {
                   MessageBox.Show(dataGridView1.Rows[rind].Cells[0].Value.ToString());
                  Profile pf = new Profile(dataGridView1.Rows[rind].Cells[0].Value.ToString(), dataGridView1.Rows[rind].Cells[1].Value.ToString(), dataGridView1.Rows[rind].Cells[2].Value.ToString(), dataGridView1.Rows[rind].Cells[3].
                      Value.ToString(), dataGridView1.Rows[rind].Cells[4]. Value.ToString(), dataGridView1.Rows[rind].Cells[5].
                      Value.ToString(), dataGridView1.Rows[rind].Cells[6]. Value.ToString(), dataGridView1.Rows[rind].Cells[7].
                      Value.ToString());
                  this.Hide();
                  pf.Show();
                // Edit means update code
            }
            else if(cind == 9)
            {
                // Delete code
                Delete_Form df = new Delete_Form(dataGridView1.Rows[rind].Cells[7].Value.ToString());
                df.Show();            
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-CEIB5MST\\SQLEXPRESS;Initial Catalog=WidowsDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Windows_Table",conn);
            SqlDataAdapter adapter= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource= dt;

            MessageBox.Show("Document refreshed");

        }
    }
}

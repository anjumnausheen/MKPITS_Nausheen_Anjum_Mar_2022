using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Mumbai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text=isCity.GetItemText(isCity.SelectedItem);
            MessageBox.Show(text);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            string address = txtAddress.Text;

            MessageBox.Show(name+ " " + address);
            Login login = new Login("Hello",name,address);
            login.Show();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

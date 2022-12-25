using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1( )
        {
            InitializeComponent();
        }

        private void txtRegister_Click(object sender, EventArgs e)
        {
            string name = txtN.Text;
            string mobile = txtM.Text;
            string password = txtP.Text;
            string email = txtE.Text;
            string state = txtS.Text;

            // MessageBox.Show(name+ " "+ mobile+" " + password+" " + email +" "+ state+" ");

            Profile pro = new Profile(name,mobile,password,email,state);
            pro.Show();
        }

      
    }
}

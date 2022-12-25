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
    public partial class Profile : Form
    {
        public Profile(string name,string mobile,string password,string email,string state)
        {
            InitializeComponent();
            txtYN.Text = name;
            txtMN.Text = mobile;
            txtYP.Text = password;
            txtYE.Text = email;
            txtYS.Text = state;
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }
    }
}

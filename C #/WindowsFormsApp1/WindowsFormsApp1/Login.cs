﻿using System;
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
    public partial class Login : Form
    {
        public Login(string str,string name,string address)
        {
            InitializeComponent();
            txtstr.Text = str;

            txtName.Text = name;
            txtmbl.Text = address;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);
            comboBox1.Items.Add(4);
            comboBox1.Items.Add(5);
            comboBox1.Items.Add(6);
            comboBox1.Items.Add(7);
            comboBox1.Items.Add(8);
            comboBox1.Items.Add(9);
            comboBox1.Items.Add(10);

            comboBox2.Items.Add("January");
            comboBox2.Items.Add("February");
            comboBox2.Items.Add("March");
            comboBox2.Items.Add("April");
            comboBox2.Items.Add("May");
            comboBox2.Items.Add("June");
            comboBox2.Items.Add("July");
            comboBox2.Items.Add("August");
            comboBox2.Items.Add("September");
            comboBox2.Items.Add("October");
            comboBox2.Items.Add("November");
            comboBox2.Items.Add("December");





            comboBox3.Items.Add("1990");
            comboBox3.Items.Add("1991");
            comboBox3.Items.Add("1992");
            comboBox3.Items.Add("1993");
            comboBox3.Items.Add("1994");
            comboBox3.Items.Add("1995");
            comboBox3.Items.Add("1996");
            comboBox3.Items.Add("1997");
            comboBox3.Items.Add("1998");
            comboBox3.Items.Add("1999");
            comboBox3.Items.Add("2000");







            comboBox4.Items.Add("India");
            comboBox4.Items.Add("Australia");
            comboBox4.Items.Add("Canada");
            comboBox4.Items.Add("Paris");
            comboBox4.Items.Add("Dubai");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

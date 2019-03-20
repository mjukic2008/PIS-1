using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        Form2 forma2;
        public Form1()
        {
            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.PasswordChar = '*';
        }

        private void login(object sender, EventArgs e)
        {
            if ("123" == textBox2.Text && "mara" == textBox1.Text)
            {
                this.Hide();
                forma2 = new Form2();
                forma2.Show();



            }
        }
    }
}

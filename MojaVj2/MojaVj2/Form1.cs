using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MojaVj2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          DialogResult result=  MessageBox.Show("Zelite li prikazati obe forme", "Pitanje",MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes) {
                Form Form3 = new Form();
                Form3.Show();
            }


          
  
        }
    }
}

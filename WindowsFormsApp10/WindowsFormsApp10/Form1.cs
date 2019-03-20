using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        private String imedatoteke = "vj5.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
         string  name = saveFileDialog1.FileName;
            if(saveFileDialog1.FileName==" ")
            { name = "vj5.txt";
    }
            File.WriteAllText(name, textBox1.Text);
        }
    }
}

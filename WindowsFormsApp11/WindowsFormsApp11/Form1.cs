using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        private StreamWriter datoteka;
        private String predefIme = "vj5.txt";
        public Form1()
        {
            InitializeComponent();
            datoteka = new StreamWriter(predefIme);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            datoteka.WriteLine(textBox1.Text);
            datoteka.Flush();
        }

        private void upaliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void ugasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void sNovimImenomToolStripMenuItem_Click(object sender, EventArgs e)
        {
           saveFileDialog1.FileName = "defaultnoime";

            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // string imedat = saveFileDialog1.FileName;

            // File.WriteAllText(imedat, textBox1.Text);
            if (saveFileDialog1.FileName == "")
            {
                saveFileDialog1.FileName = "yourFileName";
            }
            else {

                string imedat = saveFileDialog1.FileName;
            }
                
        }
    }
}

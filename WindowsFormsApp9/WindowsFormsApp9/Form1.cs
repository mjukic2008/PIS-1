using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {

       private String imedatoteke = "vj5.txt";
        StreamWriter datoteka;
        public Form1()
        {
            InitializeComponent();
            datoteka = new StreamWriter(imedatoteke);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text!="") {


                textBox2.Text = textBox1.Text;
                datoteka.WriteLine(textBox1.Text);
            };
        }

        private void pokreniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void zaustaviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void datotekaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveFileDialog dial = new SaveFileDialog();
            //OpenFileDialog dial = new OpenFileDialog();
            // dial.DefaultExt = "txt";

            /* saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
             if (saveFileDialog1.ShowDialog() == DialogResult.OK)
             {
             saveFileDialog1.ShowDialog();
                 imedatoteke = saveFileDialog1.FileName; } */
            
            saveFileDialog1.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            datoteka.Close();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
          
            imedatoteke = saveFileDialog1.FileName;
            datoteka.Close();
        }
    }
    }


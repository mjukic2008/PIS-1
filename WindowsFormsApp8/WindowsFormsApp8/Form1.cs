using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void promjena_operacije(object sender, EventArgs e)
        {
            int br1 = Convert.ToInt32(textBox1.Text);
            int br2 = Convert.ToInt32(textBox2.Text);
            int Rezultat = 0;
            switch (comboBox1.Text)
            {
                case "+":
                    Rezultat = br1 + br2;
                    break;

                case "-":
                    Rezultat = br1 - br2;
                    break;

                case "*": 
                    Rezultat = br1 * br2;
                    break;


            }
            rezultat.Text = Rezultat.ToString();
                
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nestooToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
          //  Application.Exit();
        }

        private void izlazToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}

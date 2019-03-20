using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vjezba6
{
    public partial class Form1 : Form
    {

        String ImeDatoteke;
        System.IO.StreamReader datoteka;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {

                ImeDatoteke = "udaljenost.txt";
            }

            else
            {
                ImeDatoteke = "temp.txt";
            }

            datoteka = new System.IO.StreamReader(ImeDatoteke);

            String Linija, UkupniText = "";

            while (!datoteka.EndOfStream) {
                Linija = datoteka.ReadLine();
                string[] nizlinija = Linija.Split();
                DateTime datum = DateTime.Parse(nizlinija[0]);

                if (datum>= dateTimePickerFrom.Value && datum<= dateTimePickerTo.Value)
                {

                    UkupniText += Linija + Environment.NewLine;
                }
            }

            richTextBox1.Text = UkupniText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter upis = new System.IO.StreamWriter(ImeDatoteke);
            upis.Write(textBox1.Text);
            upis.Close();
        }
    }
}

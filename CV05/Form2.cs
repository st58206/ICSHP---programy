using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CV05
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hrac hrac = new Hrac();
            hrac.Jmeno = textBox1.Text;
            //hrac.Klub = comboBox1.SelectedIndex
            hrac.GolPocet = Convert.ToInt32(textBox2.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add((FotbalovyKlub)0);
            comboBox1.Items.Add((FotbalovyKlub)1);
            comboBox1.Items.Add((FotbalovyKlub)2);
            comboBox1.Items.Add((FotbalovyKlub)3);
            comboBox1.Items.Add((FotbalovyKlub)4);
            comboBox1.Items.Add((FotbalovyKlub)5);
        }
    }
}

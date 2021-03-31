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
        public Hrac Hrac { get; set; }

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

        //Tlačítko OK
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null && ((FotbalovyKlub)comboBox1.SelectedItem) != 0)
            {
                Hrac.Jmeno = textBox1.Text;
                Hrac.Klub = (FotbalovyKlub)comboBox1.SelectedItem;
                Hrac.GolPocet = Convert.ToInt32(textBox2.Text);
                DialogResult = DialogResult.OK;
            }
            
            this.Close();
        }

        //Tlačítko Zrušit
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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

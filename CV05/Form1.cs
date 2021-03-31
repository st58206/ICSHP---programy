using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV05
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hraci hraci = new Hraci();

        //Přidat
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 popup = new Form2();
            popup.ShowDialog();
            if (popup.DialogResult == DialogResult.OK)
            {
                Hrac hrac = popup.Hrac;

                ListViewItem item = new ListViewItem(Hrac.Jmeno);
                item.SubItems.Add(Convert.ToString(Hrac.Klub));
                item.SubItems.Add(Convert.ToString(Hrac.GolPocet));
                listView1.Items.Add(item);
                hraci.Pocet++;
                hraci.Pridej(hrac);
            }
        }

        //Vymazat
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.SelectedItems[0].Remove();
                int index = listView1.SelectedIndices[0];
                hraci.Vymaz(index);
            }
            catch
            {
                Console.WriteLine("Nebyl vybrán hráč pro smazání");
            }
        }

        //Upravit
        private void button3_Click(object sender, EventArgs e)
        {

        }

        //Nejlepší kluby
        private void button4_Click(object sender, EventArgs e)
        {
            Form3 otevri = new Form3();
            otevri.ShowDialog();
        }

        //Registrovat
        private void button5_Click(object sender, EventArgs e)
        {

        }

        //Zrušit
        private void button6_Click(object sender, EventArgs e)
        {

        }

        //Konec
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public enum FotbalovyKlub
    {
        //Resharper disable InconsistentNaming
        None,
        FC_Porto,
        Arsenal,
        Real_Madrid,
        Chelsea,
        Barcelona
        //Resharper enable InconsistentNaming
    }

    public static class FotbalovyKlubInfo
    {
        private static readonly int pocet = 5;

        public static int Pocet
        {
            get { return pocet; }
        }

        public static string DejNazev(int klub)
        {
            string nazevKlubu = Convert.ToString((FotbalovyKlub)klub);
            return nazevKlubu;
        }

    }

    public class Hrac
    {
        public static string Jmeno { get; set; }
        public static FotbalovyKlub Klub { get; set; }
        public static int GolPocet { get; set; }
    }

    public class Hraci
    {
        public int Pocet { get; set; }

        public void Vymaz(int index)
        {
            this.pole[index] = null;
        }

        public void Pridej(Hrac hrac)
        {
            this.pole[Pocet - 1] = hrac;
        }

        private Hrac[] pole = new Hrac[10];

        public Hrac this[int index]
        {
            get => pole[index];
            set => pole[index] = value;
        }

        public void NajdiNejlepsiKluby(out string kluby, out int golPocet)
        {
            kluby = "něco";
            golPocet = 2;
        }

    }
}

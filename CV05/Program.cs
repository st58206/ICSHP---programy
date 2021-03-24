using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV05
{
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
        private static readonly int pocet;

        public static int Pocet
        {
            get { return pocet; }
        }

        public static void DejNazev()
        {

        }

    }

    public class Hrac
    {
        public string Jmeno { get; set; }
        public FotbalovyKlub Klub { get; set; }
        public int GolPocet { get; set; }
    }

    public class Hraci
    {
        public int Pocet { get; set; }

        public void Vymaz()
        {

        }

        public void Pridej()
        {

        }

        private int[] pole = new int[10];

        public int this[int index]
        {
            get => pole[index];
            set => pole[index] = value;
        }

        public void NajdiNejlepsiKluby()
        {

        }

    }

    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

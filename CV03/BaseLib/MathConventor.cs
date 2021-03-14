using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fei
{
    namespace BaseLib
    {
        public class MathConvertor
        {
            /// <summary>
            /// Převod z desítkové soustavy do dvojkové soustavy
            /// </summary>
            /// <param name="cislo"></param>
            /// <returns>string hodnotu</returns>
            public static string DecToBin(int cislo)
            {
                string Bin = Convert.ToString(cislo, 2);
                return Bin;
            }

            /// <summary>
            /// Převod z dvojkové soustavy do desítkové soustavy
            /// </summary>
            /// <param name="cislo">string vstup dvojkového čísla</param>
            /// <returns>int hodnotu</returns>
            public static int BinToDec(string cislo)
            {
                char[] pole = cislo.ToCharArray();
                Array.Reverse(pole);
                int sum = 0;
                for (int i = 0; i < pole.Length; i++)
                {
                    if (pole[i] == '1')
                    {
                        if (i == 0)
                        {
                            sum += 1;
                        }
                        else
                        {
                            sum += (int)Math.Pow(2, i);
                        }
                    }
                }
                return sum;
            }


            /// <summary>
            /// Převod z desítkové soustavy do římské soustavy v rozsahu 1-3999
            /// </summary>
            /// <param name="cislo">vstup číslo z desítkové soustavy</param>
            /// <returns>string</returns>
            public static string DecToRoman(int cislo)
            {
                {
                    if ((cislo < 0) || (cislo > 3999)) throw new ArgumentOutOfRangeException("Zadané číslo není v rozsahu 1-3999");
                    if (cislo < 1) return string.Empty;
                    if (cislo >= 1000) return "M" + DecToRoman(cislo - 1000);
                    if (cislo >= 900) return "CM" + DecToRoman(cislo - 900);
                    if (cislo >= 500) return "D" + DecToRoman(cislo - 500);
                    if (cislo >= 400) return "CD" + DecToRoman(cislo - 400);
                    if (cislo >= 100) return "C" + DecToRoman(cislo - 100);
                    if (cislo >= 90) return "XC" + DecToRoman(cislo - 90);
                    if (cislo >= 50) return "L" + DecToRoman(cislo - 50);
                    if (cislo >= 40) return "XL" + DecToRoman(cislo - 40);
                    if (cislo >= 10) return "X" + DecToRoman(cislo - 10);
                    if (cislo >= 9) return "IX" + DecToRoman(cislo - 9);
                    if (cislo >= 5) return "V" + DecToRoman(cislo - 5);
                    if (cislo >= 4) return "IV" + DecToRoman(cislo - 4);
                    if (cislo >= 1) return "I" + DecToRoman(cislo - 1);
                    throw new ArgumentOutOfRangeException("Špatný zápis čísla");
                }
            }

            /// <summary>
            /// Převod z římské soustavy do desítkové soustavy
            /// </summary>
            /// <param name="cislo">Římské číslo</param>
            /// <returns>int výsledek</returns>
            public static int RomanToDec(string cislo)
            {
                cislo = cislo.ToUpper();
                var vysledek = 0;

                foreach (var znak in cislo)
                {
                    vysledek += PrevodZnakuNaCislo(znak);
                }

                if (cislo.Contains("IV") || cislo.Contains("IX"))
                    vysledek -= 2;

                if (cislo.Contains("XL") || cislo.Contains("XC"))
                    vysledek -= 20;

                if (cislo.Contains("CD") || cislo.Contains("CM"))
                    vysledek -= 200;


                return vysledek;
            }

            /// <summary>
            /// Převod písmena římské číslice na číslo v deístkové podobě
            /// </summary>
            /// <param name="znak">Písmeno (znak)</param>
            /// <returns>int výsledek</returns>
            private static int PrevodZnakuNaCislo(char znak)
            {
                switch (znak)
                {
                    case 'M':
                            return 1000;

                    case 'D':
                            return 500;

                    case 'C':
                            return 100;

                    case 'L':
                            return 50;

                    case 'X':
                            return 10;

                    case 'V':
                            return 5;

                    case 'I':
                            return 1;

                    default:
                            throw new ArgumentException("Špatně zadané písmeno");

                }

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fei
{
    namespace BaseLib
    {
        public class Reading
        {
            /// <summary>
            /// Reads an integer.
            /// </summary>
            /// <param name="msg">The description</param>
            /// <returns>The int input.</returns>
            /// <exception cref="FormatException">Thrown if the input is malformed.</exception>
            public static int ReadInt(string msg)
            {
                Console.WriteLine($"{msg}: ");
                string str = Console.ReadLine();
                return int.Parse(str);
            }

            /// <summary>
            /// Čte double.
            /// </summary>
            /// <param name="msg"></param>
            /// <returns>double vstup</returns>
            /// /// <exception cref="FormatException">Thrown if the input is malformed.</exception>
            public static double ReadDouble(string msg)
            {
                Console.WriteLine($"{msg}: ");
                string str = Console.ReadLine();
                return double.Parse(str);
            }

            /// <summary>
            /// Čte char.
            /// </summary>
            /// <param name="msg"></param>
            /// <returns>char vstup</returns>
            /// /// <exception cref="FormatException">Thrown if the input is malformed.</exception>
            public static char ReadChar(string msg)
            {
                Console.WriteLine($"{msg}: ");
                string str = Console.ReadLine();
                return char.Parse(str);
            }

            /// <summary>
            /// Čte string.
            /// </summary>
            /// <param name="msg"></param>
            /// <returns>string vstup</returns>
            /// /// <exception cref="FormatException">Thrown if the input is malformed.</exception>
            public static string ReadString(string msg)
            {
                Console.WriteLine($"{msg}: ");
                string str = Console.ReadLine();
                return (str);
            }
        }

        public class ExtraMath
        {
            //Výpočet kořenů kvadratické rovnice
            public static bool KorenyKvadRovnice(float a, float b, float c, out string X1, out string X2)
            {
                float x1, x2;
                float d = b * b - 4 * a * c;
                if (d > 0)
                {
                    x1 = (-b + (float)Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - (float)Math.Sqrt(d)) / (2 * a);
                    X1 = $"x1 = {x1}";
                    X2 = $"x1 = {x2}";
                    return true;
                    //Kvadratická rovnice má dvě řešení
                }
                else if (d == 0)
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                    X1 = $"x1 = {x1}";
                    X2 = $"x1 = {x2}";
                    return true;
                    //Kvadratická rovnice má jedno řešení
                }
                else // d < 0
                {
                    X1 = null;
                    X2 = null;
                    return false;
                    //Rovnice nemá řešení v R
                }
            }

            //Generování náhodného čísla typu double
            public static double NahodneCislo(double minimum, double maximum)
            {
                Random random = new Random();
                return random.NextDouble() * (maximum - minimum) + minimum;
            }
        }

        public class MathConvertor
        {
            //Převod z desítkové soustavy do dvojkové soustavy
            public static string DecToBin(int cislo)
            {
                string Bin = Convert.ToString(cislo, 2);
                return Bin;
            }

            //Převod z dvojkové soustavy do desítkové soustavy
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

            //Převod z desítkové soustavy do římské soustavy
            /*
            public static string DecToRoman(int cislo)
            {

            }

            //Převod z římské soustavy do desítkové soustavy
            public static string RomanToDec(string cislo)
            {

            }
            */
        }
    }
}

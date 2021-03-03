using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV02_Pri02
{
    class Program
    {
        public static int[] pole;
        static void Main(string[] args)
        {
            //Příklad 01 knihovna
            try
            {
            int myInt = Fei.BaseLib.Reading.ReadInt("Your age");
            Console.WriteLine(myInt);
            }
            catch (Exception)
            {
                Console.WriteLine("The user input is malformed");
            }

            //int[] pole1d;
            //int[,] pole2d = new int[5,3];
            //int[][] zubatePole;

            try
            {
                double myDouble = Fei.BaseLib.Reading.ReadDouble("Your height");
                Console.WriteLine(myDouble);
            }
            catch (Exception)
            {
                Console.WriteLine("The user input is malformed");
            }

            try
            {
                char myChar = Fei.BaseLib.Reading.ReadChar("Your favorite letter");
                Console.WriteLine(myChar);
            }
            catch (Exception)
            {
                Console.WriteLine("The user input is malformed");
            }

            try
            {
                string myString = Fei.BaseLib.Reading.ReadString("Your name");
                Console.WriteLine(myString);
            }
            catch (Exception)
            {
                Console.WriteLine("The user input is malformed");
            }

            //Příklad 02 práce s polem
            int cislo = 0;

            while (cislo != 8)
            {
                //Uživatelské menu
                Console.WriteLine();
                Console.WriteLine("1. Zadání prvků pole z klávesnice");
                Console.WriteLine("2. Výpis pole na obrazovku");
                Console.WriteLine("3. Utřídění pole vzestupně");
                Console.WriteLine("4. Utřídění pole sestupně");
                Console.WriteLine("5. Hledání minimálního prvku");
                Console.WriteLine("6. Hledání prvního výskytu zadaného čísla");
                Console.WriteLine("7. Hledání posledního výskytu zadaného čísla");
                Console.WriteLine("8. Konec programu");
                Console.WriteLine();

                Console.WriteLine("Zadej číslo pro výběr dané položky: ");
                cislo = Convert.ToInt32(Console.ReadLine());
                //Spouštění metod pro dané zadané číslo vycházející z uživatelského menu
                switch (cislo)
                {
                    case 1:
                        Console.WriteLine();
                        pole = ZadaniPole();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine();
                        VypisPole();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine();
                        Vzestupne();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine();
                        Sestupne();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine();
                        NajdiMinimum();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine();
                        Console.WriteLine("Zadej hledané číslo");
                        int hodnota = Convert.ToInt32(Console.ReadLine());
                        PrvniVyskyt(hodnota);
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine();
                        Console.WriteLine("Zadej hledané číslo");
                        hodnota = Convert.ToInt32(Console.ReadLine());
                        PosledniVyskyt(hodnota);
                        Console.ReadKey();
                        break;
                    case 8:
                        cislo = 8;
                        break;
                    default:
                        Console.WriteLine("Špatná hodnota vstupu.");
                        Console.ReadKey();
                        break;
                }


            }
            Console.ReadKey();
        }
        public static int[] ZadaniPole()
            {
            Console.WriteLine("Zadej počet prvků pole: ");
            string str = Console.ReadLine();
            int pocet = Convert.ToInt32(str);
            int[] pole = new int[pocet];
            for(int i = 0; i < pocet; i++)
            {
                Console.WriteLine("Zadej {0}. celé číslo pole: ", i+1);
                str = Console.ReadLine();
                int prvek = Convert.ToInt32(str);
                pole[i] = prvek;
            }
            Console.WriteLine();
            return pole;

            }

        public static void VypisPole()
        {
            Console.WriteLine("Výpis pole: ");
            for(int i = 0; i < pole.Length; i++)
            {
                Console.Write($"{pole[i]} ");
            }
            Console.WriteLine();
        }

        public static void Vzestupne()
        {
            for (int i = 0; i < pole.Length; i++)
            {
                for (int j = 0; j < pole.Length - 1; j++)
                {
                    if (pole[j] > pole[j + 1])
                    {
                        int temp = pole[j];
                        pole[j] = pole[j + 1];
                        pole[j + 1] = temp;
                    }
                }
            }
            VypisPole();
        }

        public static void Sestupne()
        {
            for (int i = 0; i < pole.Length; i++)
            {
                for (int j = 0; j < pole.Length - 1; j++)
                {
                    if (pole[j] < pole[j + 1])
                    {
                        int temp = pole[j];
                        pole[j] = pole[j + 1];
                        pole[j + 1] = temp;
                    }
                }
            }
            VypisPole();
        }

        public static void NajdiMinimum()
        {
            int min = int.MaxValue;
            int index = 0;

            for (int i = 0; i < pole.Length; i++)
            {
                if (min > pole[i])
                {
                    min = pole[i];
                    index = i;
                }
            }

            Console.WriteLine($"Minimální prvek je na indexu {index} s hodnotou {min}");
        }

        public static void PrvniVyskyt(int hodnota)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] == hodnota)
                {
                    Console.WriteLine($"První výskyt hodnoty {hodnota} je na indexu {i}");
                    return;
                }
            }
        }

        public static void PosledniVyskyt(int hodnota)
        {
            int index = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] == hodnota)
                {
                    index = i;
                }
            }

            Console.WriteLine($"Poslední výskyt hodnoty {hodnota} je na indexu {index}");
        }
    }
}

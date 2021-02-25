using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV1_Pri04
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber;
            Random RNG = new Random();
            randomNumber = RNG.Next(0, 100);    //Náhodné číslo v rozsahu 0 - 100

            Console.WriteLine("Hádání náhodného čísla v rozsahu 0 - 100");

            int i = 0;
            int cislo;
            while (i < 10)
            {
                Console.Write("Zadej číslo: ");
                cislo = Console.Read();
                Console.ReadKey();

                if (cislo > 100 || cislo < -1)
                    Console.WriteLine("Zadané číslo je mimo rozsah");
                else if (cislo > randomNumber)
                {
                    Console.WriteLine("Zadané číslo je větší než náhodné číslo");
                    i++;
                }
                else if (cislo < randomNumber)
                {
                    Console.WriteLine("Zadané číslo je menší než náhodné číslo");
                    i++;
                }
                else if (cislo == randomNumber)
                {
                    Console.WriteLine("Uhádli jste náhodné číslo: " + randomNumber);
                    break;
                }
                Console.WriteLine();
            }

            if (i == 10)
                Console.WriteLine("Prohrál si");


        }
    }
}

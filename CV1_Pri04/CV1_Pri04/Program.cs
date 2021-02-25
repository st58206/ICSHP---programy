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
            randomNumber = RNG.Next(0, 101);    //Náhodné číslo v rozsahu 0 - 100

            Console.WriteLine("Hádání náhodného čísla v rozsahu 0 - 100");
            
            int i = 0;
            string potvrzeni = "Y";

            while (potvrzeni == "Y")
            {
                randomNumber = RNG.Next(0, 101);

                while (i < 10)  //Cyklus pro 10 pokusů hádání čísla
                {
                    Console.Write("Zadej číslo: ");
                    int cislo = Convert.ToInt32(Console.ReadLine());


                    if (cislo > 100 || cislo < -1)  //Kontrola zda zadané číslo je v rozsahu 0 - 100
                        Console.WriteLine("Zadané číslo je mimo rozsah");
                    if (cislo > randomNumber)
                    {
                        Console.WriteLine("Zadané číslo je větší než náhodné číslo");
                        i++;
                    }
                    if (cislo < randomNumber)
                    {
                        Console.WriteLine("Zadané číslo je menší než náhodné číslo");
                        i++;
                    }
                    if (cislo == randomNumber)
                    {
                        Console.WriteLine("Uhádli jste náhodné číslo: " + randomNumber);
                        break;
                    }


                }

                if (i == 10)    //Konec hry
                {
                    Console.WriteLine("Prohrál si");
                    potvrzeni = "N";
                    Console.ReadKey();
                }
                if(i < 10)  //Nová hra
                {
                    Console.Write("Chceš hrát znovu?[Y/N]: ");
                    potvrzeni = Console.ReadLine();
                    if (potvrzeni == "Y" || potvrzeni == "y")
                    {
                        potvrzeni = "Y";
                        Console.WriteLine();
                        Console.WriteLine("Nová hra");
                        i = 0;
                    }
                }
                
            }


        }
    }
}

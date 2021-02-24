using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV1_Pri02
{
    class Program
    {
        static void Main(string[] args)
        {
            int cislo;
            char c;
            for(int i = 65; i < 91; i++) // for cyklus pro abecedu
            {
                c = Convert.ToChar(i);
                Console.WriteLine(c);
            }

            Console.WriteLine();
            cislo = 65;
            while(cislo < 91) // while cyklus pro abecedu
            {
                c = Convert.ToChar(cislo);
                Console.WriteLine(c);
                cislo++;
            }

            Console.WriteLine();
            cislo = 65;
            do          //do..while cyklus pro abecedu
            {
                c = Convert.ToChar(cislo);
                Console.WriteLine(c);
                cislo++;
            } while (cislo < 91);

            Console.ReadKey();
        }
    }
}

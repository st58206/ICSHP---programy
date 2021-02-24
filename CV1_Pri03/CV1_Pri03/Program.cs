using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV1_Pri03
{
    class Program
    {
        static void Main(string[] args)
        {
            string pohlavi;
            string rc = "805102/1234";
            int mes = int.Parse(rc.Substring(2, 2));
            if ((mes - 50) > 0)
                pohlavi = "Žena";
            else
                pohlavi = "Muž";
            Console.Write("Pohlaví: ");
            Console.WriteLine(pohlavi);
            Console.ReadKey();
        }
    }
}

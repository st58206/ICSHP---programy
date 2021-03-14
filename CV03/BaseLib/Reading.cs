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
    }
}

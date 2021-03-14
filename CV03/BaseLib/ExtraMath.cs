using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fei
{
    namespace BaseLib
    {
        public class ExtraMath
        {
            /// <summary>
            /// Metoda pro řešení kvadratické rovnice
            /// </summary>
            /// <param name="a">Koeficient a</param>
            /// <param name="b">Koeficient b</param>
            /// <param name="c">Koeficient c</param>
            /// <param name="X1">Kořen x1</param>
            /// <param name="X2">Kořen x2</param>
            /// <returns>bool hodnota a float x1 a x2</returns>
            public static bool KorenyKvadRovnice(float a, float b, float c, out float x1, out float x2)
            {
                float d = b * b - 4 * a * c;
                if (d > 0)
                {
                    x1 = (-b + (float)Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - (float)Math.Sqrt(d)) / (2 * a);
                    return true;
                    //Kvadratická rovnice má dvě řešení
                }
                else if (d == 0)
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                    return true;
                    //Kvadratická rovnice má jedno řešení
                }
                else // d < 0
                {
                    x1 = float.NaN;
                    x2 = float.NaN;
                    return false;
                    //Rovnice nemá řešení v R
                }
            }

            /// <summary>
            /// Metoda generuje náhodné číslo v daném rozsahu
            /// </summary>
            /// <param name="minimum">Minimální hodnota</param>
            /// <param name="maximum">Maximální hodnota</param>
            /// <returns>double</returns>
            public static double NahodneCislo(double minimum, double maximum)
            {
                Random random = new Random();
                return random.NextDouble() * (maximum - minimum) + minimum;
            }
        }

    }
}

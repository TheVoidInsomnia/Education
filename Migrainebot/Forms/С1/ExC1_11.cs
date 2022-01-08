using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    internal class ExC1_11
    {
        //C1.11. Считая, что Земля — идеальная сфера с радиусом R = 6370 км,
        //определить расстояние до линии горизонта от точки с высотой над Землей, равной 1, 2, … 10 км.
        public static void Run()
        {
            var radius = 6370f;
            
            for (int i = 10; i >=0; i--)
            {
                
                var height = i;
                var c = radius + height;

                var distance = Math.Sqrt(c * c - radius * radius);
                Console.WriteLine(distance);

            }

        }
    }
}

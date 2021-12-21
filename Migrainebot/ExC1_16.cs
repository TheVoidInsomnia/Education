using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C1.16. Напечатать «столбиком» значения sin(2) , sin(3) , …, sin(20) .
    internal class ExC1_16
    {
        public static void Run()
        {
            for (var i = 0; i <= 20; i++)
            {
                var number= Math.Sin(i);
                Console.WriteLine($"{number}");
            }
        }
    }

}

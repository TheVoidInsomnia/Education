using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C1.22. Вывести «столбиком» следующие числа: 4,4,  4,6,  4,8,  …, 6,4.
    internal class ExC1_22
    {
        public static void Run()
        {
            for (var i = 4.4f; i <= 6.4f; i+=0.2f)
            {
                Console.WriteLine(i);
            }
        }
    }
}

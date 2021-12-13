using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //Напечатать ряд чисел 20 с помощью цикла for
    internal class ExC1_1
    {
        public static void Run()
        {
            var outNum = 20;
            var count = 5;
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{outNum} ");
            }
        }
    }
}

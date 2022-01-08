using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C3.1. Даны числа a1, a2, …, a10. Определить их сумму.
    internal class ExC3_1
    {
        public static void Run()
        {
            var sum = 0;
            int [] nums= { 1, 2, 3, 4, 6, 5, 8, 7, 9, 10 };
            for (int i = 0; i < 10; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }
        
    }
}

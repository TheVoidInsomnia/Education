using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C2.5. Дано натуральное число n. Найти сумму:  n^2 + (n+1)^2 + … + (2n)^2.
    internal class ExC2_5
    {
        
        public static void Run()
        {
            Console.WriteLine("Введите число:");
            var n=Convert.ToInt32(Console.ReadLine());
            var sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                //sum = sum + Math.Pow(n + i, 2);
                sum += Math.Pow(n + i, 2);
              
            }
            Console.WriteLine($"{n}^2+{sum}+ ... + (2{n})^2");
        }   
    }
}

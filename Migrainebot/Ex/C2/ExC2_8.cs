using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C2.8. Вычислить сумму:  1 +1/2 + 1/3 + … + 1/n.
    internal class ExC2_8
    {
        public static void Run()
        {
            Console.WriteLine("Введите число:");
            var n=Convert.ToInt32(Console.ReadLine());
            var sum = 0.0;
            for (int i = 1; i <= n; i++ )
            {
                sum += 1 / Convert.ToDouble(i);
            }
            Console.WriteLine($" 1 +1/2 + 1/3 + … + 1/n = {sum}");
        }
    }
}

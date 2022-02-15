using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C4.8. Найти сумму 2^2 + 2^3 + 2^4 + … + 2^10.
    //Операцию возведения в степень не использовать.
    internal class ExC4_8
    {
        public static void Run()
        {
            int a = 2;
            int sum = 0;
            for (int i = 1; i < 10; i++)
            {
                a *= 2;
                sum += a;
            }
            Console.WriteLine(sum);


        }
    }
}

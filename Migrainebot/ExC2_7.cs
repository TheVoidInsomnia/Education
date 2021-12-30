using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C2.7. Вычислить сумму:  2/3 +3/4 +4/5 +… 10/11.
    internal class ExC2_7
    {
        public static void Run()
        {
            
            var sum = 0.0;
            for (int i = 2; i <= 10; i++)
                sum += i / (Convert.ToDouble(i) + 1);
            Console.WriteLine(sum);
        }
    }
}

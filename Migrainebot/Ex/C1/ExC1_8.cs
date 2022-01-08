using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C1.8. Напечатать таблицу соответствия между весом в фунтах и весом в
    //килограммах для значений 1, 2, …, 10 фунтов (1 фунт = 453 г).
    internal class ExC1_8
    {
        public static void Run()
        {
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine($"{i} {i*453}");
            }
                    
        }
    }
}

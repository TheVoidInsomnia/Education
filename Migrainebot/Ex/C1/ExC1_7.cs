using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C1.7. Одна штука некоторого товара стоит 55,99 руб.
    //Напечатать таблицу стоимости 2, 3, …, 20 штук этого товара.
    internal class ExC1_7
    {
        public static void Run()
        {
            for (var i = 1; i <=20; i++)
            {   
                Console.WriteLine($"{i} {55.99*i}");
            }
        }
    }
}

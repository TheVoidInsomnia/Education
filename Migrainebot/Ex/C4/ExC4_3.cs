using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C4.3. Одноклеточная амеба каждые 3 часа делится на 2 клетки.
    //Определить, сколько клеток будет через 3, 6, 9, …, 24 часа,
    //если первоначально была одна амеба.
    internal class ExC4_3
    {
        public static void Run()
        {
            var cell = 1;
            for (int i=3; i<=24; i+=3)
            {
                cell *= 2;
                Console.WriteLine($"Через {i} часов будет {cell} клеток");
            }
            
        }
    }
}

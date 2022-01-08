using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    // A2.12. Дано натуральное число n (n > 9). Найти:
    // а) число единиц в нем;
    // б) число десятков в нем.
    internal class Ex2_12
    {
        public static void Run()
        {
            var number = 0;
            while (number <= 9)
            {
                Console.WriteLine("Введите число больше 9");
                number = Convert.ToInt32(Console.ReadLine());
            }

            var number1 = number % 10;
            var number2 = number % 100 / 10;
            Console.WriteLine($"Число единиц равно:{number1}");
            Console.WriteLine($"Число десятков равно:{number2}");


        }
    }
}

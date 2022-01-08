using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //A2.13. Дано натуральное число n (n > 99). Найти:
    //а) число десятков в нем;
    //б) число сотен в нем.
    internal class Ex2_13
    {
        public static void Run()
        {
            var number = 0;
            while (number <= 99)
            {
                Console.WriteLine("Введите число больше 99");
                number = Convert.ToInt32(Console.ReadLine());
            }

            var number1 = number % 100 / 10;
            var number2 = number % 1000 / 100;
            Console.WriteLine($"Число десятков равно:{number1}");
            Console.WriteLine($"Число сотен равно:{number2}");

        }


    }
}

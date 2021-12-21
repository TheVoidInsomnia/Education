using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C1.15. Напечатать таблицу умножения на число n (значение n вводится с клавиатуры; 1 <= n <= 9).
    internal class ExC1_15
    {
        public static void Run()
        {
            Console.WriteLine("Введите число:");
            var number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{number} * {i} = {i * number}");
            }
        }
    }
}
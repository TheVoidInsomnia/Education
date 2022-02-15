using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C4.1. Последовательность Фибоначчи образуется так:
    //первый и второй члены последовательности равны 1,
    //каждый следующий равен сумме двух предыдущих (1, 1, 2, 3, 5, 8, 13, …).
    //Дано натуральное число n (n > 3).
//а) Найти k-й член последовательности Фибоначчи.
//б) Получить первые n членов последовательности Фибоначчи.
    internal class ExC4_1
    {
        public static void Run()
        {
            Console.WriteLine("Введите число n (n>3):");
            var n = Convert.ToInt32(Console.ReadLine());
            int[] number = new int[n];
            number[0] = 1;
            number[1] = 1;
            



        }
    }
}

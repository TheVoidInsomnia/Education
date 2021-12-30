using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C3.2. Даны натуральное число n и вещественные числа a1, a2, …, an.
    //Определить сумму всех вещественных чисел.
    internal class ExC3_2
    {
        public static void Run()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Console.WriteLine($"Введите число: (меньше {nums.Length})");
            var number=Convert.ToInt32(Console.ReadLine());
            var sum = 0;
            while (number >= nums.Length)
            {
                Console.WriteLine($"Ошибка, вы ввели число больше {nums.Length}");
                Console.WriteLine($"Введите число: (меньше {nums.Length})");
                number = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= number; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }
    }
}

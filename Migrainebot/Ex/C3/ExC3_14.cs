using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C3.14. Известны оценки по физике каждого из 20 учеников класса.
    //Определить среднюю оценку.
    internal class ExC3_14
    {
        public static void Run()
        {
            var sum = 0;
            var arithmeticalMean=0;
            int[] nums = {5, 4, 5, 4, 5, 3, 5, 4, 3, 2, 5, 3, 5, 4, 5, 3, 4, 5, 4, 3};
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                arithmeticalMean = sum / nums.Length;
            }
            Console.WriteLine($"{arithmeticalMean}");
        }
    }
}

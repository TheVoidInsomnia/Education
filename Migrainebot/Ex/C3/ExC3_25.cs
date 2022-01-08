using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C3.25. В области 10 районов.
    //Заданы площади, засеваемые пшеницей (в гектарах),
    //и средняя урожайность (в центнерах с гектара) в каждом районе.
    //Определить количество пшеницы, собранное в области, и среднюю урожайность по области.
    internal class ExC3_25
    {
        public static void Run()
        {
            Console.WriteLine("Введите число:"); //площади, засеваемые пшеницей (в гектарах)
            var number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число: ");//средняя урожайность (в центнерах с гектара) в каждом районе
            var number2=Convert.ToInt32(Console.ReadLine());
            var arithmeticalMean = 0.0;
            var sum = 0.0;
            int[] nums = {10,20,30,40,50,60,70,80,90,100}; 
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            arithmeticalMean = sum / nums.Length;
            Console.WriteLine($"{arithmeticalMean}");
            Console.WriteLine($"");
        }
    }
}

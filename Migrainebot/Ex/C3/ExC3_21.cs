using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C3.21.Известен возраст (в годах в виде 14,5 лет и т. п.) каждого ученика двух классов.
    //Определить средний возраст учеников каждого класса.
    //В каждом классе учатся 20 человек.
    internal class ExC3_21
    {
        public static void Run()
        {
            var arithmeticalMean = 0.0;
            var sum=0.0;
            float[] nums = { 12.5f, 14.5f, 12.5f, 14.5f, 12.5f, 14.5f, 12.5f, 14.5f, 12.5f, 14.5f, 12.5f, 14.5f, 12.5f, 14.5f, 12.5f, 14.5f, 12.5f, 14.5f, 12.5f, 14.5f, 12.5f, 12.5f, 14.5f, 12.5f, 14.5f, 12.5f, 14.5f, };
            float[] nums2 = { 12.5f, 19.5f, 16.5f, 14.5f, 19.5f, 19.5f, 11.5f, 19.5f, 12.5f, 14.5f, 13.5f, 14.5f, 19.5f };
            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            arithmeticalMean = sum / nums.Length;
            Console.WriteLine($"{arithmeticalMean}");
            arithmeticalMean = 0.0;
            sum = 0.0;
            for (var a = 0; a < nums2.Length; a++)
            {
                sum += nums2[a];
            }
            arithmeticalMean = sum / nums2.Length;
            Console.WriteLine($"{arithmeticalMean}");
        }
    }
}

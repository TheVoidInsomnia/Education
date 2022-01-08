using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C3.4. Известны оценки абитуриента на четырех экзаменах.
    //Определить сумму набранных им баллов.
    internal class ExC3_4
    {
        public static void Run()
        {
            var sum=0;
            int[] nums = { 20, 60, 80, 100 };
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }
    }
}

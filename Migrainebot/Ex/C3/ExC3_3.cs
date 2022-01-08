using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C3.3.Известна масса каждого из 12 предметов.
    //Определить общую массу всего набора предметов.
    internal class ExC3_3
    {
        public static void Run()
        {
            var weight = 0.0;
            int [] nums = {10,20,30,40,50,60,70,80,90,100,110,120};
            for (int i = 0; i < nums.Length; i++)
            {
              weight += nums[i];
            }
            Console.WriteLine(weight);
        }
    }
}

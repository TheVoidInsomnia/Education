using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    internal class Ex1_19
    {

        public static void Alt()
        {
            var result = new DateTime(2020, 1, 30).AddMonths(6).AddDays(2).ToString("MM-MMMM");
            Console.WriteLine(result);
        }

        public static void Run()
        {
            var start = 6;
            var startmonths = 1;
            var monthoffset = (start + startmonths);
            Console.WriteLine($"Месяцев прошло:{monthoffset}");
            switch (monthoffset)
            {

                case 1: Console.WriteLine("Jan"); break;
                case 2:Console.WriteLine("Feb");
                    break;
                case 3: Console.WriteLine("Mar");
                    break;
                case 4:
                    Console.WriteLine("Apr");
                    break; ;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("Jun");
                    break;
                case 7:
                    Console.WriteLine("Jul");
                    break;
                case 8:
                    Console.WriteLine("Aug");
                    break;
                case 9:
                    Console.WriteLine("Sen");
                    break;
                case 10:
                    Console.WriteLine("Oct");
                    break;
                case 11:
                    Console.WriteLine("Now");
                    break;
                case 12:
                    Console.WriteLine("Dec");
                    break;

            }
        }
    }
}

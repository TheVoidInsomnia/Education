using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    internal class Digithelper
    {
        /// <summary>
        /// представить число в ввиде списка цифр
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<int> GetDigits(int value)
        {
            var list = new List<int>();
            GetDigits(value, list);
            return list;
        }
        //452
        public static void GetDigits(int value, in List<int> result)
        {
            if (value >= 10)
            {
                GetDigits(value / 10, result);
            }
            result.Add(value % 10);
        }

        /// <summary>
        /// Получить число в интервале от start до end
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static int InputNumberInInterval(int start, int end)
        {
            if (start > end) throw new ArgumentException($"number start({start}) must be less than end({end})");
            var number = 0;
            bool incorrectInput = true;
            Console.WriteLine($"Введите число от {start} до {end}, включительно");
            while (incorrectInput)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number >= start && number <= end)
                {
                    incorrectInput = false;
                }
                else
                {
                    Console.WriteLine($"Число должно быть в интервале от {start} до {end} включительно, повторите ввод");
                }
            }
            return number;
        }
    }
}

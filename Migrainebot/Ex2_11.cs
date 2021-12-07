using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    /*
     2.11. Дано четырехзначное число. Найти:
     а) число, полученное при прочтении его цифр справа налево;
     б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр заданного числа.
     Например, из числа 5434 получить 4543, из числа 7048 — 784;
    в) число, образуемое при перестановке второй и третьей цифр заданного числа. 
    Например, из числа 5084 получить 5804;
    г) число, образуемое при перестановке двух первых и двух последних цифр заданного числа.
    Например, из числа 4566 получить 6645, из числа 7304 — 473.
    Последнюю задачу решить двумя способами:
    1) с выделением отдельных цифр заданного числа;
    2) без выделения отдельных цифр заданного числа.
     */
    internal class Ex2_11
    {
        public static void Run()
        {
            //а) var number = Digithelper.GetDigits(3456);
            //for (var i = number.Count - 1; i >= 0; i--)
            //Console.Write(number[i]);
            // var number = "3456";
            // б) Console.WriteLine($"{number[1]}{number[0]}{number[3]}{number[2]}");
            // в) var number = "5084";
            //Console.WriteLine($"{number[0]}{number[2]}{number[1]}{number[3]}");
            // г) var number = "4566";
            //Console.WriteLine($"{number[2]}{number[3]}{number[0]}{number[1]}");
            var number = "4566";
            Console.WriteLine();
            

        }

    }
}

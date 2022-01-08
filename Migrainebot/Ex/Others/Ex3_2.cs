using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //A3.2. Из трехзначного числа x вычли его последнюю цифру.
    //Когда результат разделили на 10, а к частному слева приписали последнюю цифру числа x,
    //то получилось число n. Найти число x.
    //Значение n вводится с клавиатуры, 100 ≤ n ≤ 999 и при этом число десятков в n не равно нулю.
    internal class Ex3_2
    {

        public static void Run()
        {
            bool flag = true;
            while (flag)
            {
                var number = Digithelper.InputNumberInInterval(100, 999);
                var numbers = Digithelper.GetDigits(number);

                if (numbers[1] != 0)
                {
                    Console.WriteLine($"{numbers[1]}{numbers[2]}{numbers[0]}");
                    Console.WriteLine();
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Ошибка: число десятков не должно быть равно нулю");
                }
            }











        }
    }
}

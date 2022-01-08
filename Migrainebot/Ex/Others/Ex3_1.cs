using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //A3.1. Из трехзначного числа x вычли его последнюю цифру.
    //Когда результат разделили на 10, 
    //а к частному слева приписали последнюю цифру числа x, то получилось число 237. 
    //Найти число x.
    internal class Ex3_1
    {
        public static void Run()
        {
            var number1 = 237f;
            var number2 = Math.Floor(number1 / 100);
            var number3=Math.Floor(number1 % 100);
            var x = number3 * 10 + number2;
            Console.WriteLine(x);



        }


    }
}

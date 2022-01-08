using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //A3.3. В трехзначном числе x зачеркнули первую цифру. Когда оставшееся число умножили на 10,
    //а произведение сложили с первой цифрой числа x, то получилось число 564.
    //Найти число x.
    internal class Ex3_3
    {
        public static void Run()
        {
            var number = 564f;
            var number1 = Math.Floor(number / 10);
            var number2 = Math.Floor(number % 10) * 100;
            Console.WriteLine(number1+number2);
          
        }
    }
}

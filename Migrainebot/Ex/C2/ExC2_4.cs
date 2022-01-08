using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C2.4. Найти:
//а) сумму кубов всех целых чисел от 20 до 40;
//б) сумму квадратов всех целых чисел от a до 50 (значение a вводится с клавиатуры; 0<a<=50);
//в) сумму квадратов всех целых чисел от 1 до n(значение n вводится с клавиатуры; 1<=n<=100);
//г) сумму квадратов всех целых чисел от a до b(значения a и b вводятся с клавиатуры; b>a).
    internal class ExC2_4
    {
        public static void Run()
        {
            var sum = 0.0;
            Console.WriteLine("Введите число:");
            var number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число:");
            var number2=Convert.ToInt32(Console.ReadLine());
            for (var i = number1; i <= number2; i++)
            {
                sum = sum + Math.Pow(i , 2);
                Console.WriteLine(sum);
            }
        }
    }
}
// а)    var sum = 0;
//for (var i = 20; i <= 40; i++)
//{
//sum = sum + (i * i * i);
//Console.WriteLine(sum);
//}
// б) var sum = 0.0;
//Console.WriteLine("Введите число:");
//var number = Convert.ToInt32(Console.ReadLine());
//for (var i = number; i <= 50; i++)
//{
//sum = sum + Math.Pow(i, 2);
//Console.WriteLine(sum);
//}
//в) var sum = 0.0;
//Console.WriteLine("Введите число:");
//var number = Convert.ToInt32(Console.ReadLine());
//for (var i = 1; i <= number; i++)
//{
   //sum = sum + Math.Pow(i, 2);
    //Console.WriteLine(sum);
//}
        
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
   //C2.1. Найти:
   //а) сумму всех целых чисел от 100 до 500;
   //б) сумму всех целых чисел от a до 500 (значение a вводится с клавиатуры; a<500);
   //в) сумму всех целых чисел от –10 до b(значение b вводится с клавиатуры; b>–10);
   //г) сумму всех целых чисел от a до b(значения a и b вводятся с клавиатуры; b>a).
    internal class ExC2_1
    {
        public static void Run()
        {
            Console.WriteLine("Введите число a:");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b:");
            var number2= Convert.ToInt32(Console.ReadLine());
            var sum = 0;
            for (int i = number1+1; i <= number2; i++)
            {
                sum = sum + i;
                Console.WriteLine(sum);
            }
            
        }
    }
}
// a) var number = 0;
//for (int i = 100; i <= 500; i++)
//{
//number = number + i;
//Console.WriteLine(number);
//}
// б) Console.WriteLine("Введите число:");
//var number = Convert.ToInt32(Console.ReadLine());
//for (int i = number + 1; i <= 500; i++)
//{
//number = number + i;
//}
//Console.WriteLine(number);
//}
//в) Console.WriteLine("Введите число:");
//var number = Convert.ToInt32(Console.ReadLine());
//var sum = 0;
//for (int i = -10; i <= number; i++)
//{
    //sum = sum + i;
    //Console.WriteLine(sum);
//}
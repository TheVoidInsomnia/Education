using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C2.2. Найти:
    //а) произведение всех целых чисел от 8 до 15;
    //б) произведение всех целых чисел от a до 20 (значение a вводится с клавиатуры; 1<=a<=20);
    //в) произведение всех целых чисел от 1 до b(значение b вводится с клавиатуры; 1<=b<=20);
    //г) произведение всех целых чисел от a до b(значения a и b вводятся с клавиатуры; b>a).
    internal class ExC2_2
    {
        public static void Run()
        {
            Console.WriteLine("Введите число:");
            var number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число:");
            var number2=Convert.ToInt32(Console.ReadLine());
            var sum = 1;
            for (int i = number1; i <= number2; i++)
            {
                sum=sum*i;
                Console.WriteLine(sum);
            }
        }
    }
}

//a) var sum = 1;
//for (int i = 8; i <= 15; i++)
//{
//sum = sum * i;
//Console.WriteLine(sum);
//}
//б) Console.WriteLine("Введите число:");
//var number = Convert.ToInt32(Console.ReadLine());
//var sum = 1;
//for (int i = number + 1; i <= 20; i++)
//{
//sum = sum * i;
//Console.WriteLine(sum);
//}
//в) Console.WriteLine("Введите число:");
//var number = Convert.ToInt32(Console.ReadLine());
//var sum = 1;
//for (int i = 1; i <= number; i++)
//{
    //sum = sum * i;
    //Console.WriteLine(sum);
//}
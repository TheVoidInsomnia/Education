using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{ 
    //C1.3. Напечатать «столбиком»:
    //а) все целые числа от 20 до 35;
    //б) квадраты всех целых чисел от 10 до b(значение b вводится с клавиатуры; b > 10);
    //в) третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a< 50);
    //г) все целые числа от a до b(значения a и b вводятся с клавиатуры; b<a).
    internal class ExC1_3
    {
        public static void Run()
        {
            Console.WriteLine("Введите число b (a>b):");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число a (a>b):");
            var a = Convert.ToInt32(Console.ReadLine());
            while (b>a)
            {
                Console.WriteLine("Ошибка! Число a должно быть больше числа b");
                Console.WriteLine("Введите число b (a>b):");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ошибка! Число a должно быть больше числа b");
                Console.WriteLine("Введите число a (a>b):");
                a = Convert.ToInt32(Console.ReadLine());

            }
            for (var i = a; i >= b; i--)
            {
                Console.WriteLine(i);
               
            }

        }

    }
}
// a) for (int i = 20; i < 36; i++) 
//Console.WriteLine(i);

// б) Console.WriteLine("Введите число больше 10:");
//var b = Convert.ToInt32(Console.ReadLine());
//while (b < 10)
//{
//Console.WriteLine("Введите число больше 10");
//b = Convert.ToInt32(Console.ReadLine());

//}

//for (var i = 10; i <= b; i++)
//{
//Console.WriteLine(Math.Pow(i, 2));
//}

// в)
//Console.WriteLine("Введите число, которое не больше 50:");
//var a = Convert.ToInt32(Console.ReadLine());
//while (a >= 50)
//{
    //Console.WriteLine("Введите число, которое не больше 50:");
    //a = Convert.ToInt32(Console.ReadLine());

//}
//for (var i = a; i < 50; i++)
//{
    //Console.WriteLine(Math.Pow(i, 3));
//}

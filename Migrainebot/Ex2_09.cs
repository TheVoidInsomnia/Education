using System.Collections.Generic;

namespace Migrainebot
{
    /*
     Дано трехзначное число, в котором все цифры различны. 
     Получить шесть чисел, образованных при перестановке цифр заданного числа.
     */

    class Comp
    {
        // Пример Generic 
        public static T Min<T>(T a, T b) where T : IComparable
        {
            var result = a.CompareTo(b);
            if (result == 0) return a;
            if (result == 1) return a;
            return b;
        }

        public static void Run()
        {
            Comp.Min(10, 20);
            Comp.Min(10.0, 10.0);
            Comp.Min(10m, 15m);
            Comp.Min("sss", "111");
        }
    }

    class Ex2_09
    {
        public static List<string> MakeVariants(String number)
        {
            var result = new List<string>();
            
            for (var i = 0; i < number.Length; i++)
            {
                
                for (var k = 0; k < number.Length; k++)
                {
                    if (number[i] == number[k]) continue;

                    for (var j = 0; j < number.Length; j++)
                    {
                        if (number[j] == number[k] || number[j] == number[i]) continue;
                        result.Add($"{number[i]}{number[k]}{number[j]}");
                    }
                }
            }
            return result;
        }
        public static void Run()
        {
            for(int i = 100; i < 1000; i++)
            {
                var number = i.ToString();
                if (number[0] == number[1] || number[0] == number[2] || number[1] == number[2])
                    continue;
                var result = MakeVariants(i.ToString());
                var check = new HashSet<string>(result);
                if (check.Count != result.Count || result.Count != 6)
                    throw new Exception($"Error at {i}");
            }
            //123 132 213 231 312 321
        }
    }
}




















//if (a <100)
//{
//    a += a *0.05;
//}
//else if (a <= 200)
//{
//    a += a * 0.07;
//}
//else
//{
//    a += a * 0.1;
//}
//Console.WriteLine($"Сумму вклада после начисления процентов: {a}");

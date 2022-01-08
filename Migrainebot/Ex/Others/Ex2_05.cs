namespace Migrainebot
{
    /*

        A2.5. Дано трехзначное число. 
        В нем зачеркнули первую слева цифру и приписали ее в конце. Найти полученное число.

     */
    class Ex2_05
    {
        public static void Run()
        {
            var number = "341";
            Console.WriteLine($"{number[1]}{number[2]}{number[0]}");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C1.10. Напечатать таблицу перевода 1, 2, … 20 долларов США в рубли
    //по текущему курсу (значение курса вводится с клавиатуры).
    internal class ExC1_10
    {
        public static void Run()
        {
            var number = 0.0;
           // while (number<0)
            {
                try
                {
                    Console.WriteLine("Введите курс рубля:");
                    number = Convert.ToDouble(Console.ReadLine());

                    for (var i = 0; i <= 20; i++)
                    {
                        Console.WriteLine($"{i} {i * number}");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error {ex.Message}");
                    
                }


            }
        }
    }
}

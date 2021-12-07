using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot


{    /*
      2.10. Дано четырехзначное число. Найти:
      а) сумму его цифр;
      б) произведение его цифр.
      */

    internal class Ex2_10
    {
        public static void Run()
        {
            var arrayofdigits = Digithelper.GetDigits(2222);
            var sum = 0;
            var prod = 1;
            foreach (var item in arrayofdigits)
            {
                sum += item;
                prod *= item;
                Console.WriteLine(item);
            }
            Console.WriteLine(sum);
            Console.WriteLine(prod);
        }


    }
}

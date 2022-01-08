using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    internal class ExC1_4
    {
        //C1.4. Напечатать числа следующим образом:
        //а)                      
        //10 10.4                   
        //11 11.4
        //...
        //25 25.4

        //б)
        //25 25.5 24.8
        //26 26.5 25.8
        //...
        //35 35.5 34.8

        public static void Run()
        {
            for (int i = 25; i <= 35; i++)
            {
                Console.WriteLine($"{i} {i + 0.5} {i-0.2}");
            }
            //for (var j = 24; j <= 34; j++)
            //{
               //Console.WriteLine($"{j + 0.8}");
            //}

        }
    }
} 
 
//а) 
    //for (int i = 10; i <= 25; i++)
//{
   //Console.WriteLine($"{i} {i + 0.4}");
//}

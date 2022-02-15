using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C3.27. В области 12 районов.
    //Известны количество жителей каждого района (в тысячах человек)
    //и плотность населения в нем (тыс. чел./км2).
    //Определить общую площадь территории области.
    internal class ExC3_27
    {
        public static void Run()
        {
            var totalArea = 0.0;
            int[] numberofHabitants = {100, 21, 34, 75, 35, 28, 84, 98, 45, 36, 92, 12};
            int[] populationDensity = { 1, 2, 3, 4, 5, 5, 1, 3, 5, 2, 1, 2 };
            for (int i=1; i<=12;i++)
            {
                totalArea += numberofHabitants[i] * populationDensity[i];

            }
            Console.WriteLine("{totalArea");

        }
    }
}

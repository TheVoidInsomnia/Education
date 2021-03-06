using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //C3.25. В области 10 районов.
    //Заданы площади, засеваемые пшеницей (в гектарах),
    //и средняя урожайность (в центнерах с гектара) в каждом районе.
    //Определить количество пшеницы, собранное в области, и среднюю урожайность по области.
    internal class ExC3_25
    {
        public static void Run()
        {
            var productivityofArea = 0.0;
            var squareofArea = 0.0;
            int[] squares = { 15, 25, 35, 45, 55, 65, 75, 85, 90, 100 };

            int[] arithmeticalMeans = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            if (arithmeticalMeans.Length != squares.Length)
            {
                throw new ArgumentException("Количество площадей района, должно соотвествовать количеству урожайности районов");
            }

            for (int i = 0; i < arithmeticalMeans.Length && i < squares.Length; i++)
            {
                productivityofArea += arithmeticalMeans[i] * squares[i];
                squareofArea += squares[i];
            }

            double arithmeticalMean = productivityofArea / squareofArea;

            Console.WriteLine($"{productivityofArea}");
            Console.WriteLine($"{arithmeticalMean}");
           
        }
    }
}

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
    internal class AreaData
    {
        public int productivity = 0;
        public int square = 0;

        //Произведенно в районе
        public int production => productivity * square;
    }
    
    internal class ExC3_25_alt
    {
        public static void Run()
        {
            AreaData[] areas =
            {
                new AreaData() {productivity = 10, square = 15},
                new AreaData() {productivity = 12, square = 25},
                new AreaData() {productivity = 11, square = 7},
                new AreaData() {productivity = 15, square = 8},
                new AreaData() {productivity = 11, square = 20}
            };

            var productivityofArea = 0.0;
            var squareofArea = 0.0;

            for (int i = 0; i < areas.Length; i++)
            {
                productivityofArea += areas[i].production;
                squareofArea += areas[i].square;
            }

            double arithmeticalMean = productivityofArea / squareofArea;
           // var area = areas.Sum(x => x.square);
            //var total = areas.Sum(x => x.production);


            Console.WriteLine($"{productivityofArea}");
            Console.WriteLine($"{arithmeticalMean}");
           
        }
    }
}

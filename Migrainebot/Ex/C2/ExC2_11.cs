using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    //«Странный муж». Некий мужчина отправляется на работу,
    //которая находится на расстоянии 1 км от дома.
    //Дойдя до места работы, он вдруг вспоминает,
    //что перед уходом забыл поцеловать жену, и поворачивает назад.
    //Пройдя полпути, он меняет решение, посчитав, что правильнее вернуться на работу.
    //Пройдя 1/3 км по направлению к работе, он вдруг осознает,
    //что будет настоящим подлецом, если так и не поцелует жену.
    //На этот раз, прежде чем изменить мнение, он проходит 1/4 км.
    //Так он продолжает метаться, и после N-этапа, пройдя 1/N км,
    //снова меняет решение. Определить:
    //а) на каком расстоянии от дома будет находиться мужчина после 100-го этапа(если допустить, что такое возможно);
    //б) какой общий путь он при этом пройдет.
    internal class ExC2_11
    {
        public static void Run()
        {
            bool toWork = true;
            var sum = 0.0;
            var distanceFromHome = 0.0;
            for (var i = 1; i <= 100; i++)
            {
                var distanceAtStep = 1 / (Convert.ToDouble(i));
                sum += distanceAtStep;
                if (toWork)
                {
                    distanceFromHome += distanceAtStep;
                    toWork = false;
                }
                else
                {
                    distanceFromHome -= distanceAtStep;
                    toWork = true;
                }
                
                //toWork = !toWork;

            }
            Console.WriteLine($"1/3+1/4+...+1/i = {sum}");
            Console.WriteLine(distanceFromHome);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrainebot
{
    internal class Digithelper
    {
        public static List<int> GetDigits(int value)
        {
            var list = new List<int>();
            GetDigits(value, list);
            return list;
        }
        //452
        public static void GetDigits(int value, in List<int> result)
        {
            if (value >= 10)
            {
                GetDigits(value / 10, result);
            }
            result.Add(value % 10);
        }
    }
}

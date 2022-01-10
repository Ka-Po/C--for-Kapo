using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<LemonTea> lemonTea = new List<LemonTea>{
                new LemonTea(8,"特大",4),
                new LemonTea(7,"大杯",3),
                new LemonTea(6,"中杯",2),
                new LemonTea(5,"細杯",1),
            };

            var result = from tea in lemonTea
                         where tea.sweetLevel > 5 && tea.size != "中杯"
                         orderby tea.Ord
                         select tea;

            foreach (var tea in result)
            {
                Console.WriteLine(tea.sweetLevel + tea.size);
            }

           // Console.WriteLine("Hello World!");
        }
    }

    public struct LemonTea
    {
        public int sweetLevel;
        public string size;
        public int Ord;
        public LemonTea(int sweetLevel, string size,int ord)
        {
            this.sweetLevel = sweetLevel;
            this.size = size;
            this.Ord = ord;
        }
    }
}

using System;
using static System.Console;                            //簡化顯示的輸入指令

namespace BasisArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 3, 5, 8, 9, 5, 0 };

            Write("原本陣列：");
            foreach (int item in number)                //用foreach顯示陣列內的元素
            {
                Write($"{item,2} ");
            }
            WriteLine();                                //隔行
            WriteLine();                                //空行

            #region 搜尋
            Write("搜尋："); WriteLine();


            int first = Array.IndexOf(number, 5);
            WriteLine($"向後揾5，陣列位置： {first}");

            int Last = Array.LastIndexOf(number, 5);
            WriteLine($"向後揾5，陣列位置： {Last}");

            int unknown = Array.IndexOf(number, 4);
            WriteLine($"向後揾4，陣列位置： {unknown}");
            #endregion

            WriteLine();

            #region 排序
            Write("排序：");

            Array.Sort(number);                         //由細到大去排序
            WriteLine();
            Write("由細到大：");
            foreach (int item in number)
            {
                Write($"{item,2} ");
            }

            Array.Reverse(number);                      //反轉陣列，由大到細去排序
            WriteLine();
            Write("由大到細：");
            foreach (int item in number)
            {
                Write($"{item,2} ");
            }
            #endregion

            //ReadKey();                                //Window機會用到
        }



    }
}

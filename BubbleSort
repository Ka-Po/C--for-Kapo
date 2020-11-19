using System;
using static System.Console;                        //引用Console，可以減小顯示指令的輸入

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 5, 7, 1, 4, 2, 6, 3 };        //陣列的資料，有7個元素！
            DisplayDate(data, "陣列資料：");
            BubbleSortMethod( data, CompareFun[0]);                                   
            DisplayDate(data, "排序後的順序：");
        }

        static public void DisplayDate(int[] data,String Showtext)
        {
            Write(Showtext);
            for ( int i = 0; i < data.Length; i++)
            {
                Write(data[i] + " ");
            }
            WriteLine();
        }

        public static void BubbleSortMethod(int[] data, IsLarger LargerThan)
        {
            int a, b;
            for (a = data.Length - 1; a > 0; a--){      //排序的次數
                for (b = 0; b < a; b++){                //每次比較完，陣列項就向後移一個位
                    if (LargerThan(data[b], data[b + 1]) == true)
                    {         
                        Swap(ref data[b],ref data[b + 1]);//兩個數比較大細，反轉這個不等號就會反轉排序
                    }
                }
                DisplayDate(data, "在第" + (data.Length - a) + "次交換元素後的排序：");
            }
        }

        public static void Swap(ref int b, ref int c)
        {
            int tmp;
            tmp = b;
            b = c;
            c = tmp;
        }


        #region 委派
        public delegate bool IsLarger(int X, int Y);
        public static IsLarger[] CompareFun = { AC, DC };

        public static bool AC(int X, int Y)
        {
            if (X > Y) return true;//遞增
            else return false;
        }
        public static bool DC(int X, int Y)
        {
            if (X < Y) return true;//遞減 
            else return false;
        }
        #endregion

    }
}

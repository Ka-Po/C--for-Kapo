using System;
using static System.Console;

namespace HollowWorld
{
    class MainClass//Lamdba
    {
        //public delegate int varAdd3(int x, int y);
        //public varAdd3 Add3;

        //Func<int, int, int> Add4;

        public static void Main(string[] args)
        {
            //int a;
            //int b;
            //int e = 5;

            //a = 1;
            //b = 2;
            //int c = Add(a, b);

            Func<int, int, int> Add2 = (x, y) => { int z = x + y; return z; };

            //Func<int, int, int> varAdd2 = Add;                      //引用方法變數就冇括號！

            int d = Add2(1, 2);

            WriteLine(d);

        }


        public static int Add(int a, int b)
        {
            //int z = x + y;
            return a + b;
        }
    }
}


//匿名方法，參數不用寫形態。

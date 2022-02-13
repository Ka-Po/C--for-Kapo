using System;

namespace Deletgate
{

    public delegate void de();            //宣告新形態
    public delegate string de2(int a);

    public class MainClass
    {
        public int X;
        public de a;                            //方法變數

        public static void Main(string[] args)
        {
            de B = method1;            //類似宣告int,string型態
            B();

            Action B2 = method1;
            B2();

            //
            de2 C = method2;
            C(1);

            Func<int,string> func = method2;
            Console.WriteLine(func(1));

            //
            void method1()
            {
                Console.WriteLine("a");
            }

            string method2(int a)
            {
                return a.ToString();
            }

            //

            Predicate<int> isEven = IsEven;
            Console.WriteLine(isEven(5));

            bool IsEven(int number)
            {
                return number % 2 == 0;
            }

            CL cL = new CL();
            cL.funtion3();

            de D = new de(method1);    //類似宣告實例化類別：CL cl = new CL();
            D();                                          //但執行起來都是作為方法去執行

        }
    }

    class CL
    {
        public void funtion3()
        {
            Console.WriteLine("funtion3");
        }
    }


}

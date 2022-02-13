using System;

namespace SendAddr
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a; int b;
            a = 1; b = 2;

            int c = Add(a,b);
            Console.WriteLine($"{c}");

            Swap(ref a,ref b);

            Console.WriteLine($"{a},{b}");

        }
        static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static int Add(int a,int b)
        {
            return a + b;
        }
    }
}

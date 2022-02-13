using System;
using System.Collections.Generic;

namespace Generic
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //int c = 2;
            //string d = "d";

            //GenericMethod GM = new GenericMethod();

            //GM.M1(d);

            GenericClass<int> GC = new GenericClass<int>();

            //GC.M2(3);

            Dg1<int> dg1 = GC.M2;

            dg1(3);

        }
    }


    public class GenericMethod
    {
        public void M1<T>( T b)
        {
            Console.WriteLine(b);
        }
    }

    public class GenericClass<T>
    {
        public void M2(T b)
        {
            Console.WriteLine(b);
        }
    }

    public delegate void Dg1<T>(T c);


}

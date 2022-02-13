using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");

            //A b = new B();                  // 
            //b.ShowText();

            //A[] a = new A[2];
            //a[0] = new B();
            //a[1] = new C();

            List<A> a2 = new List<A>();
            a2.Add( new B());
            a2.Add( new C(2,4));

            float SumArea = 0.0f;
            foreach (var item in a2)
            {
                //   item.ShowText();
              SumArea +=  item.Area();
            }
            Console.WriteLine($"{SumArea}");

        }
    }

    abstract class A
    {
        abstract public void ShowText();
        //{
        //    Console.WriteLine("A!");
        //}

        abstract public float Area();

    }

    class B:A
    {
        override public void ShowText()
        {
            Console.WriteLine("B!");
        }

        override public float Area()
        {
            return 2;
        }
    }

    class C:A
    {
        override public void ShowText()
        {
            Console.WriteLine("C!");
        }

        public float h, w;
        public C(float h,float w)
        {
            this.h = h;
            this.w = w;
        }

        override public float Area()
        {
            return h*w;
        }

    }


}

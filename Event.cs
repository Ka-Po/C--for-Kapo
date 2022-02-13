using System;

namespace Event
{
    class MainClass
    {
        public  delegate void de();
        public static event de ShowText;                    // event可以保護delegate

        public static void Main(string[] args)
        {
            void HelloWorld()
            {
                Console.WriteLine("Hello World!");
            }
            void HelloWorld2()
            {
                Console.WriteLine("Hello World2!");
            }

            ShowText = HelloWorld;
            ShowText += HelloWorld2;
            ShowText();

            de A = HelloWorld; ;
            A += HelloWorld2;
            A();

        }
    }
}

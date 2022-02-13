using System;
using System.Threading;

namespace ThreadTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            void count()
            {
               int  sum = 0;
                while (sum<int.MaxValue)
                {
                    sum++;
                }

                Console.WriteLine("Counting Finish!");
            }

            ThreadStart thdStart = new ThreadStart(count);
            Thread thd = new Thread(thdStart);

            thd.Start();
            Console.WriteLine("Hello World !");
        }
    }
}

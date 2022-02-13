using System;

namespace ClassAndStruct
{
    class MainClass
    {
        class PointClass
        {
            public float x;
            public float y;
        }
        static void ChangeX(PointClass t)
        {
            t.x = 10;
        }

        struct PointStruct                                
        {
            public float x;
            public float y;
        }
        static void ChangeY(PointStruct t)
        {
            t.y = 10;
        }

        public static void Main(string[] args)
        {
            PointClass c = new PointClass();
            ChangeX(c);                                     // 傳址，有冇加ref都冇分別！

            PointStruct d = new PointStruct();
            ChangeY( d);                                    // 傳值，結構要加ref 才會傳址！

            Console.WriteLine($"{c.x}");
            Console.WriteLine($"{d.y}");
        }
    }
}

//結果顯示：
//10
//0





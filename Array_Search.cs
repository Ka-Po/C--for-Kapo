using System;
using System.Collections.Generic;

namespace Array_Search
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Point[] points = {
                                new Point{X=1,Y=2},
                                new Point{X=2,Y=3},
                                new Point{X=3,Y=4},
            };

            Point[] point2 = Array.FindAll(points, FindNumber);

            foreach (var item in point2)
            {
                Console.WriteLine("Find Point using Array : " + item.X + " , " + item.Y);
            }

            // 用 List 方式去搜尋
            List<Point> listPoint = new List<Point>() {
                                                                                    new Point{X=1,Y=2},
                                                                                    new Point{X=2,Y=3},
                                                                                    new Point{X=3,Y=4},
            };

            List<Point> listPoint2 = listPoint.FindAll(FindNumber);

            foreach (var item in listPoint2)
            {
                Console.WriteLine("Find Point using List : " + item.X + " , " + item.Y);
            }


            //int[] Number = { 1, 2, 3 };

            //if (Find3(Number))
            //{
            //    Console.WriteLine("Find 3!");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found 3!");
            //}

            ////  Console.WriteLine("Hello World!");

        }

        static public bool FindNumber(Point points)
        {
            return points.X * points.Y >= 5;
        }

        //static public bool Find3(int[] a)
        //{
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i] == 3)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }

    class Point
    {
        public int X;
        public int Y;
    }

}

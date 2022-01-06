using System;

namespace Indexer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Indexer ind = new Indexer();
            ind[2] = 22;
            Console.WriteLine(ind[2]);
        }
    }

    //陣列類別
    class Indexer
    {
        int[] number = new int[5];
        public int this[int index]      //索引子
        {
            get { return number[index]; }
            set { number[index] = value; }
        }
    }

}

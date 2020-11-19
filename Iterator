using System;
using static System.Console;
using System.Collections;

namespace IteratorTest
{
    public class Node
    {
        public int Data;
        public Node Next;
        public Node(int y)
        {
            Next = null;
            Data = y;
        }
    }

    public class SimpleList
    {
        private Node head = null;
        public void Add(int y)
        {
            Node n = new Node(y);
            n.Next = head;
            head = n;
        }

        #region 迭代器
        public IEnumerable Iterator()
        {
            Node current = head;
            while (current != null)
            {
                //WriteLine(current.Data + "  ");

                yield return current.Data;
                current = current.Next;
            }
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            SimpleList list = new SimpleList();

            int[] number = new int[3] { 1, 2, 3 };
            foreach (int x in number)
                list.Add(x);

            //list.Iterator();

            foreach (int z in list.Iterator())
                Write(z + "  ");
            //ReadLine();
        }
    }
}

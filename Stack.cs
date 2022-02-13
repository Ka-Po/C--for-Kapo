using System;
using static System.Console;

namespace StackMethod
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StackByKapo stack = new StackByKapo(3);

            WriteLine("輸入3個數字：");

            for (int i = 0; i < 3; i++)
            {
                int value = int.Parse(ReadLine());
                stack.PutIn(value);
            }

            while (stack.Empty()==false)
                WriteLine("堆疊的輸出次序：" + stack.TakeOut());
            }
        }

    class StackByKapo
    {
               int[] stack;
               int pointer;
              
               public StackByKapo(int stack_size)
               {
                   stack = new int[stack_size];
                   pointer = 0;
               }
              
               public void PutIn(int data)
               {
                   stack[pointer] = data;
                   pointer=pointer+1;
              }
              
               public int TakeOut()
               {
                   pointer=pointer-1;
                   return stack[pointer];           //return stack[--top];  
              }

            public bool Empty()
            {
            if (pointer == 0) return true;
            else return false;
            }

    }
}


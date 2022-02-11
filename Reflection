using System;
using OtherSpace;
using System.Reflection;
using System.Collections.Generic;

namespace Reflection
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //          Console.WriteLine("Hello World!");

            MyClass my = new MyClass();
            Type type = my.GetType();       // 類別資料 變數  形態 Type

            //System.Reflection.BindingFlags flags = System.Reflection.BindingFlags.Public
            //                                                                   | System.Reflection.BindingFlags.NonPublic ;
            //    | System.Reflection.BindingFlags.Instance ;
            //     | System.Reflection.BindingFlags.Static ;


            //System.Reflection.FieldInfo[] fieldArray = type.GetFields(flags);
            //foreach (var item in fieldArray)
            //{
            //    Console.Write(item.Name + "  " + "Type = " + item.FieldType.Name + "\n");
            //}

            System.Reflection.MethodInfo[] MethodArray = type.GetMethods();
            foreach (var item in type.GetMethods())
            {

                Console.Write("Method = " + item.Name + "  " + "ReturnType = " + item.ReturnType.Name + "\n");

                //foreach (var item2 in item.GetParameters())
                //{
                //    if (item2.ParameterType.Name == "MyClass")
                //    {
                //        Console.Write("Method = " + item.Name + "  " + "ReturnType = " + item.ReturnType.Name + "\n");
                //    }
                //}

            }

            //System.Reflection.Assembly assembly = my.GetType().Assembly;
            ////  Console.Write(assembly.FullName + "\n");\
            //Type[] type2 = assembly.GetTypes();
            //foreach (var item in type2)
            //{
            //    Console.Write(item + "\n");
            //}

        }
    }
}

namespace OtherSpace
{
      class MyClass  
    {
        //欄位，Field
        //public string name;
        //public int number;
        
        //private int _age;
 //       public int age { get; set; }  //屬性，Property

        // 方法，Method
        public void M1() { }
 //       public void M2(MyClass myClass) { }

    }
}

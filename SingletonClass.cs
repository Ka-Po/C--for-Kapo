using System;

namespace SingletonObject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SingletonClass.SingletonObject.M1();

            //Console.WriteLine("Hello World!");
        }
    }

    public class SingletonClass
    {
        private static SingletonClass _singletonObject;
        public static SingletonClass SingletonObject{
            get{
                if (_singletonObject==null){
                    _singletonObject = new SingletonClass();
                }
                return _singletonObject;
            }
        }

        public void M1()
        {
            Console.WriteLine("Hello World!");
        }
    }
}

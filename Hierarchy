using System;

namespace Hierarchy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            KapoGroup kapoGroup = new KapoGroup();
            kapoGroup.Myjob();

            //LankapoGroup lankapoGroup = new LankapoGroup();
            //lankapoGroup.Myjob();

            //Console.WriteLine("Hello World!");
        }
    }

    class Designer
    {
        public virtual void Myjob()
        {
            Console.WriteLine("i am designer !");
        }
    }

    class KapoGroup: Designer
    {
        //public void Myjob()
        //{
        //    Console.WriteLine("i am designer !");
        //}
    }

    class LanGroup : Designer
    {
    //    public void Myjob()
    //    {
    //        Console.WriteLine("i am designer !");
    //    }
    }

    class LankapoGroup:Designer
    {
       public override void Myjob()
        {
            Console.WriteLine("i am designer and Youtuber !");
        }
    }

    interface TypeA_Car
    {
        void CleanShell();
        void CleanSeat();
        void CleanWheel();
    }

    class CarA
    {
        public void CleanShell()
        {
            Console.WriteLine("Use liquid A clean the Shell !");
        }

        public void CleanSeat()
        {
            Console.WriteLine("Use liquid B clean the Seat !");
        }

        public void CleanWheel()
        {
            Console.WriteLine("Use liquid C clean the Wheel !");
        }
    }

    class CarB: TypeA_Car
    {
        public void CleanShell()
        {
            Console.WriteLine("Use liquid X clean the Shell !");
        }

        public void CleanSeat()
        {
            Console.WriteLine("Use liquid Y clean the Seat !");
        }

        public void CleanWheel()
        {
            Console.WriteLine("Use liquid X clean the Wheel !");
        }
    }


}

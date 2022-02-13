using System;

namespace DesignPatten{
    class MainClass{
        public static void Main(string[] args){


            Equipment ExMon = new Equipment("顯示器", "藍色");



            Computer PC1 = new Computer("電腦", "白色",ExMon);
            Equipment Mouse = new Equipment("滑鼠", "黑色");
            PC1.powerUp += Mouse.ConnectPower;
            Equipment Keyboard = new Equipment("鍵盤", "黑色");
            PC1.powerUp += Keyboard.ConnectPower;

            Equipment2 Monitor = new Equipment2("顯示器", "白色", PC1);

            PC1.PowerUp();
        }
    }

    public delegate void Powerconnect();

    class Computer
    {
        private string name;
        private string color;
        public Computer(string name,string color,Equipment eq)
        {
            this.name = name;
            this.color = color;

            powerUp += eq.ConnectPower;


        }
        #region 兩個類別的連結方式
        public void PowerUp()
        {
            Console.WriteLine(color + "的" + name + "啟動電源了！");

            if (powerUp != null)
                powerUp();
        }

        public Powerconnect powerUp;
        //public Action powerUp2;       //簡化委派的宣告
        #endregion
    }

    class Equipment
    {
        private string name;
        private string color;

        public Equipment(string name,string color)
        {
            this.name = name;
            this.color = color;
        }

        public void ConnectPower()
        {
            Console.WriteLine(color + "的" + name + "可以用！");
        }
    }

    class Equipment2
    {
        private string name;
        private string color;

        public Equipment2(string name, string color,Computer pc)
        {
            this.name = name;
            this.color = color;

            pc.powerUp += ConnectPower;

        }

        public void ConnectPower()
        {
            Console.WriteLine(color + "的" + name + "可以用！");
        }
    }


}

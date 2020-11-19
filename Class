using System;

namespace Class{
    class MainClass {
        public static void Main(string[] args) {
            BaseClass baseclass, mC;                                 //類別的分拆宣告方法
            mC = new BaseClass("kapo");                              //引數對應參數放入變數值
            baseclass = mC;

            baseclass.Acceleration = 122;

            ////mC.name = "kapo";                                   //代入
            ////mC.amount = 12;

            Console.WriteLine(string.Format("Name:{0},Amount:{1}, Acceleration:{2}",
                baseclass.name, baseclass.amount, baseclass.Acceleration));                 //顯示

            //baseclass.Function();

            //V3 v = new V3(1f, 2f, 3f);
            ////v.zero();                           //zero不是方法
            ////v = V3.zero();                      //用類別的第一條建構式去代入v物件的值
            ////v = V3.zero;                        //引用簡化左的寫法，冇（）
            //Console.WriteLine(string.Format("{0},{1},{2}",
            //    v.x, v.y,v.z));



            //V3 v3;         //不能在這句加public，類別內有static！

            //V3 v1 = new V3(12f, 3f, 6f);
            //V3 v2 =  V3.one;          //這個方式建立物件不用new關鍵字

            //V3 v = v1 + v2;           //這個方式建立物件不用new關鍵字

            //Console.WriteLine(string.Format("{0},{1},{2}",
            //    v.x, v.y, v.z));

        }
    }


    #region In Unity

    //public class ParentClass : MonoBehaviour
    //{

    //}

    //public class Classes : ParentClass
    //{

    //}
    #endregion


    #region 類別的基本結構

    public class BaseClass{
        public string name;                             //欄位：儲存文字或數值的變數
        public int amount;
        public void Function()                          //方法：執行程式：例如代入數值，＋-*/的運算，顯示資料。
        {
            Console.WriteLine(string.Format("Name:{0},Amount:{1}",
            name, amount));
        }
        private float _acceleration;
        public float Acceleration                       //屬性變數：將輸入與輸出分開處理
        {
            get {return _acceleration; }
            set
            {
                _acceleration = value;
                if (_acceleration > 120)
                {
                    _acceleration = 120;
                }

            }
        }

        /// <summary>
        /// 類別的基本成員：欄位，方法，屬性
        /// </summary>
       

        #region 建構式：初始化物件時候執行

        public BaseClass()                            //建構式要同類別同名
        {
            name = "Default";
            amount = 1;
        }

        public BaseClass(string _name)                //建構式的多載overload
        {
            name = _name;
            amount = 2;
        }

        public BaseClass(string _name, int _amount)    //第3條建構式
        {
            name = _name;
            amount = _amount;
        }
        #endregion
    }
    #endregion


    #region 重新定義3D向量

    public class V3
    {
        public float x;
        public float y;
        public float z;

        public V3()                     //第1條建構式
        {
            x = 0f;
            y = 0f;
            z = 0f;
        }

        public V3(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        //public static V3 zero()         //需要冇參數的第1條建構式
        //{
        //    return new V3();
        //}

        public static V3 zero             //用get簡代寫法,宣告及引用時省略括號（）
        {
            get { return new V3(); }
        }

        public static V3 one               //單位向量
        {
            get { return new V3(1f,1f,1f); }
        }

        // 建立同類別（V3）的四則運算之中的加法
        public static V3 operator+ (V3 a,V3 b)
        {
            V3 v3 = new V3();

            v3.x = a.x + b.x;
            v3.y = a.y + b.y;
            v3.z = a.z + b.z;

            return v3;
        }

    }

    #endregion

}
//快速鍵：
//搜尋同字同時修改他們：commend+R;
//區塊選擇：option+R

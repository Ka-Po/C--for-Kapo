using System;

namespace ConsoleApplication1{
    class Program{
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("陣列的數字:");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " "); 
            }
            Console.WriteLine("\r\n搜尋陣列內的數字:");
            int SearchNumber1 = Convert.ToInt32(Console.ReadLine());
            int returValue = SearchByBinary(array1, SearchNumber1);
            if (returValue == -1)
            {
                Console.WriteLine("没有資料被發現!");
            }
            else
            {
                Console.WriteLine("搜尋值的陣列所在編號:" + returValue);
            }
            Console.ReadLine();
        }

        private static int SearchByBinary(int[] array2, int SearchNumber2)
        {
            int left = 1;
            int right = array2.Length;

            try
            {
                while (left <= right)
                {
                    int mid = (left + right) / 2;           //陣列的中間數
                    if (array2[mid] == SearchNumber2)
                    {
                        return mid;                         //找到所要搜尋值後回傳
                    }
                    else
                    {
                        if (array2[mid] < SearchNumber2)
                        {
                            left = mid + 1;                 //向右移動的參數
                        }
                        else
                        {
                            right = mid - 1;                //向左移動的參數
                        }
                    }
                }
                return -1;                                  //細過下限，回傳-1
            }
            catch 
            {
                return -1;                                  //大過上限，回傳-1
            }

        }
    }
}

using System;
using System.IO;
using System.Text;

namespace Base_IO
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string path = @"/Users/kapo/Desktop";

                if (Directory.Exists(path))
                {
                    Console.WriteLine("/Users/kapo/Desktop .<--- This path exists.");

                #region 建立檔案

                string path2 = @"/Users/kapo/Desktop\MyTest.txt";

                using (FileStream fs = File.Create(path2))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("Some text in the file.");
                    fs.Write(info, 0, info.Length);
                    Console.WriteLine("Create MyTest.txt in the Desktop file, same level file.");
                }
                //在終端機顯示檔案的文字
                using (StreamReader sr = File.OpenText(path2))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                #endregion

                return;
            }
            else
            {
                Console.WriteLine("That path not exists .");
                return;
            }

        }
    }
}

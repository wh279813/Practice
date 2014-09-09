using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 返回值
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("您确定要关机吗？<y/n>");
            string s = Readanwser();    //调用方法Readanwser
            if (s == "y")
            {
                Console.WriteLine("正在关机中，请稍等~~~~~");
            }
            Console.ReadKey();

            

        }
        public static string Readanwser()   //在返回值处，加上返回值的数据类型
        {
            string Anwser = "";
            
            do
            {
                Anwser = Console.ReadLine();
                if (Anwser != "y" && Anwser != "n")
                {
                    Console.WriteLine("您的输入有误，请重新输入");

                }


            }
            while (Anwser != "y" && Anwser != "n");
            return Anwser;   //return指令返回值
        }
    }
}

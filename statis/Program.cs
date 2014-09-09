using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statis
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Main:主方法
            //void：表示方法无返回值
            //参数要写在小括号里面


            UI();     //调用方法 
            int a = 0, b = 5;
            add(a, b);
            UI();
            Console.ReadKey();

        }
        public static void UI()
        {
            
            Console.WriteLine("************************************************************");
            Console.WriteLine("                        欢迎使用                            ");
            return;   //立刻跳跳出方法
            Console.WriteLine("************************************************************");
        }
        public static void add(int a,int b)    //参数写在括号里
        {
            Console.WriteLine("a+b={0}",a+b);
            //Console.ReadKey();

        }

    }
}

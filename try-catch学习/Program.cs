using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch学习
{
    class Program
    {
        static void Main(string[] args)
        {
            //题目：不断要求用户输入一个数字（正整数）,当用户输入end的时候输出刚才输入数字的最大值.
            //string anwser;
            //int n = 0;
            //bool flag=true;

            //do
            //{

            //    try
            //    {
            //        Console.WriteLine("请输入一个正整数：");
            //        n = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("{0}的二倍是{1}",n,n*2);
            //        flag = true;

            //    }
            //    catch
            //    {
            //        flag = false;


            //    }
            //}


            //while (flag ==true);


            //Console.ReadKey();


            string input;
            int n = 0, m = 0;
            Console.WriteLine("请输入一个正整数：");
            input = Console.ReadLine();
            while (input != "end") 
            {
                n=Convert.ToInt32(input);
                if (n > m) 
                m = n;
                Console.WriteLine("请输入一个正整数：");
                input = Console.ReadLine();
            }
            Console.WriteLine("最大的正整数为:"+m);
            Console.ReadKey();





        }
    }
}

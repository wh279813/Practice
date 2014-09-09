using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 链表
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入小球的个数：");
            int n = Convert.ToInt32(Console.ReadLine());//定义小球的个数 n
            int[] Ball = new int[n];//定义一个n个整形元素的数组
            //把每个小球从1到n编号
            for (int i = 1; i <= n; i++)
            {
                Ball[i] = i;
            }

            Console.WriteLine("请输入指令条数：");
            int m=Convert.ToInt32(Console.ReadLine());//定义指令的条数 m
            for (int i = 0; i < m;i++ )//使用循环结构依次输入m条指令
            {
                Console.WriteLine("请输入第{0}条指令：",i+1);
                

            }
        




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 九九乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 9; n++) 
            {
                for (int m = 1; m <= n; m++)
                {
                    Console.Write("{0}*{1}={2:00} ", n, m, n * m);//:00的作用 占位符必须有2位 不足两位则补零  或者使用\t
                }
                Console.WriteLine();
            }
                
            Console.ReadKey();
        }
    }
}

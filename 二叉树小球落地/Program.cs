using System;


namespace 二叉树小球落地
{
    /// <summary>
    /// 基本思想:忽略之前过程，第n个小球是从2^(n-1)位开始落下的
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入叶子深度D:");
            int d = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("请输入小球的个数n：");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = (int)Math.Pow(2, d) - 1;//定义最大的数为2 的d次方

            for (int i = 1; i <= n; i++)
            {
                int s = (int)Math.Pow(2, i) - 1;//实质上第n个小球是从2^n-1位开始的
                for (; ; )
                {
                    if ((s * 2) > a)//大于2^d时跳出
                        break;
                    s = s * 2;//只要定义了起点，结果一直乘以2即可
                }
                Console.WriteLine(s);
            }
            Console.ReadKey();

          
        }
    }
}

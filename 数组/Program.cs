using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组可以一次声明多个同类型的变量，这些变量在内存中是连续存贮的。
            //一次测试后，统计全班60个人的成绩，并计算全班平均成绩，然后把成绩显示出来
            int[]score = new int[4];              //数组名：score   里面包含60个元素 
            int sum=0;
            //score[0] = 123;                        //第一个同学成绩123;
            //score[1] = 121;
            //score[5] = 100;                        //未赋值的初始化为0;
            //score[59] = 125;                       //60个元素为0-59;
            for (int i = 0; i < score.Length; i++)     //用for循环结构赋值
            {
                Console.WriteLine("请输入第{0}个人的成绩：",i+1);
                score[i]=Convert.ToInt32(Console.ReadLine());
                sum=sum+score[i];
            }

            for (int i=0; i < score.Length;i++ )
            {
                Console.WriteLine("请{0}个人的成绩是{1}。",i+1,score[i]);
            }
            Console.ReadKey();
            Console.Clear();                        //清屏指令

            Console.WriteLine("全班平均成绩为"+sum/score.Length);
            Console.ReadKey();

        }
    }
}

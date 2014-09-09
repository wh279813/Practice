using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举_结构
{
    class Program
    {
        enum gender
        {
            男,
            女
        }
        public struct person
        {
            public string name;
            public string sex;
            public int age;
        }
        
        static void Main(string[] args)
        {
            person Zhangshan;
            Zhangshan.name = "张三";
            Zhangshan.sex =  "男";
            Zhangshan.age = 20;

            person Lisi;
            Lisi.name = "李四";
            Lisi.sex = "男";
            Lisi.age = 21;

            Console.WriteLine("我叫{0}，性别{1}，今年{2}岁了。",Zhangshan.name,Zhangshan.sex,Zhangshan.age);
            Console.ReadKey();

        }
    }
}

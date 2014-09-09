using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //题目：提示用户输入用户名和密码，当分别不是admin和888888的时候，提示重新输入，知道输入成功。
            string username;
            string password;
           
           
            while (true)
            {
                Console.WriteLine("请输入用户名：");
                username = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                password = Console.ReadLine();
      
                if (username != "admin" || password != "888888")
                {
                    Console.WriteLine("错误，请重新输入。");
                   
                }
                else
                    break;
                
            }
            Console.WriteLine("登录成功。");
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //输出100--999之间的水仙花数（a^3*b^3*c^3=a*b*c）
            Console.WriteLine("水仙花数为：");
            for (int n = 153; n <= 999; n++) 
            {
                int hundred =  n/ 100;
                int ten = (n-hundred*100) / 10;
                int unit = n-hundred*100-ten*10;
                if (hundred * hundred * hundred + ten * ten * ten + unit * unit * unit == n)
                    Console.WriteLine("{0}",n);
                
            }
            Console.ReadKey();
        }
    }
}

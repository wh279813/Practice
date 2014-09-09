using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continue练习
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int n = 1; n <= 100; n++)
            {
                if (n % 7 == 0)
                    continue;
                sum = n + sum;

            }
           
            Console.WriteLine(sum);
            Console.ReadKey();
        }
       
    }
}

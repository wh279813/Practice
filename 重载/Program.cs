using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 重载
{
    public class Shape 
{
   public static void main(String[] args){
     Triangle tri = new Triangle();
     Console.WriteLine("Triangle is a type of shape? " + tri.isShape());// 继承
     Shape shape = new Triangle();
     Console.WriteLine("My shape has " + shape.getSides() + " sides."); // 多态
     Rectangle Rec = new Rectangle();
     Shape shape2 = Rec;
     Console.WriteLine("My shape has " + shape2.getSides(Rec) + " sides."); //重载
     Console.ReadKey();
   }
   public Boolean isShape()
   {
     return true;
   }
   public int getSides()
   {
     return 0 ;
   }
   private virtual int getSides(Triangle tri)
   {
       //重载
     return 3 ;
   }
   private int getSides(Rectangle rec)
   {
       //重载
     return 4 ;
   }
}

class Triangle : Shape 
{
   public override int getSides()
   {
       //重写,实现多态
     return 3;
   }
}
class Rectangle : Shape 
{
   public int getSides(int i)
   {
       //重载
     return i;
   }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonHome1
{
    class Program
    {
        static void Main(string[] args)
      {
      
            Shape Star1= new Shape;      
            Rectangle Star2= new Rectangle;
                

            Console.WriteLine(Star1.Draw);
            Console.WriteLine(Star2.Draw);
        }

            abstract class Shape
      {
          public double Square;
          public double Perimetr;
          public double Color;
          public void Draw();

      }
        public void Draw();
        {
        Perimetr=Square+4;
        }
        public class Rectangle : Shape
        {
        public:
        int side;
        int bisector;
        int point;    
        
        public void Draw();
        {
        Perimetr=Square+2;
        }
    }
}

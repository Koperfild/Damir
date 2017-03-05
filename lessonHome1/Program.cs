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
            //Для вызова конструктора по умолчанию надо писать тоже (). Будет new Shape();
            Shape Star1 = new Shape;
            Rectangle Star2 = new Rectangle;

            //Для вызова методов без параметра надо писать после него (). Т.е. будет Star1.Draw()
            Console.WriteLine(Star1.Draw);
            Console.WriteLine(Star2.Draw);
        }
    }
    public abstract class Shape
    {
        public double Square;
        public double Perimetr;
        public double Color;


        public void Draw()
        {
            Perimetr = Square + 4;
        }
    }
    public class Rectangle : Shape
    {
        public int side;
        public int bisector;
        public int point;

        public void Draw()
        {
            Perimetr = Square + 2;
        }
    }
}

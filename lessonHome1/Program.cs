﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonHome1
{
    class Program
    {
        //создай класс Rectangle. У него сделай поля - сторона а и сторона б. 
        //Сделай 2 конструктора. Один принимает 1 число и делает квадрат, 
        //т.е. а и б равны этому числу. А второй конструктор уже принимает 
        //2 значения - длину а и длину б.

        static void Main(string[] args)
        {
            Rectangle Gipotinuse = new Rectangle (10.0, 5.0);
            Console.WriteLine("1й катет равен " + Gipotinuse.SideA + " второй " + Gipotinuse.SideB + 
                " сумма их квадратов равна:\n"+Gipotinuse.Sum()+"\n");
            
            Rectangle Gipotinuse2 = new Rectangle (12.0);
            Console.WriteLine("если гипотенуза равна "+Gipotinuse2.SideC+" , то ее квадрат равен:\n"+Gipotinuse2.Sum2());
            Console.ReadKey();
        }

        class Rectangle
        {
            public double SideA;
            public double SideB;
            public double SideC;
            public Rectangle (double a, double b)
            {                             
                SideA=a;
                SideB=b;  
            }
            public Rectangle (double c)
            {
                SideC=c;
        
            }
                public double Sum2 ()
                {
                    return SideC *= SideC;
                }      
           
            public double Sum ()
            {               
                return SideA*SideA+SideB*SideB;
            }
        }
    }
}
            
            
            //public double Square (double c) // метод
            //{
            //   c*=c;
            //}
            //public Rectangle(double a, double b) //конструктор
            //{
            //    SideA = a;
            //    SideB = b;
                
            //    public double Sum ()
            //    {                
//            //    return 
//            //        Rectangle.* a + b * b;
//            //    }
//            }
           

//        }
//    }
//}
////        
            





            
            
            //public class RightAngledTriangle // класс RightAngledTriangle - прямоугольный треугольник. 
//            //Сделай поля - все стороны и углы. И сделай конструкторы по 2 катетам, по одному 
//            //катету и прилегающему к нему углу, по гипотенузе. Т.е. все конструкторы 
//            //будут с параметрами double a, double b. Компилятор будет ругаться, но я потом 
//            //покажу как это надо изменить чтобы работало
//            {
//            public double a; // гипотенуза
//            public double b; //катет
//            public double c; //катет
//            public double Angle1;
//            public double Angle2;
//            public double Angle3;
//                public double FindA()
//                    {
//                        a=Math.Sqrt(b*b+c*c);
//                        return a;
//                    }
//                public double FindB()
//                    {
//                        b=Math.Sqrt(a*a-c*c);
//                        return a;
//                    }

//                public double FindC()
//                    {
//                        c=Math.Sqrt(a*a-b*b);
//                        return a;
//                    }
//            }
        
//              RightAngledTriangle Leg1 = new RightAngledTriangle   // конструктор №1
//              {
//                double a=5.0;
//                double b=10.0;
//                double FindA ()
//                {
//                Console.WriteLine("Гипотенуза равна:" FindA());
//                }
//                double FindB ()
//                {
//                    double a=9;
//                    double c=7;
//                    Console.WriteLine("Катет равен1:" FindB());
//                }
//                double FindС ()
//                {
//                    double a=6;
//                    double b=8;
//                    Console.WriteLine("Катет равен2:" FindС());
//                }
//    }
//}

           
                //В прямоугольном треугольнике есть 3 стороны и 3 угла. Из известных 
                //2-х величин можно посчитать все остальные
                //т.е. в конструторе считаются все остальные величины из данных двух
                //если это 2 катета, то считается гипотенуза и углы
                //в зависимости от того что известно





//        {   // почему тут требует закрыть блок? я же внизу закрыл.
//            //Ты сделал класс внутри метода класса Program. Сделай класс вне класса Program.
//            // не понял, почему нельзя внутри Program. мы ведь раньше всегда здесь все писали.

//            //Этот код уже идёт вне класса.
//            //List<OddNumbers> list1 = new List<OddNumber>();
//            //У тебя команды вне метода написаны
//            Number Get1 = new Number();
            
//            //Вызывай теперь твой метод так
//            Get1.AddNumber

//            //хз чё ты хотел этим сказать) Чувствуется С++ восприятие мира
//            int GetOddNum ()
//            {
//                for (num = 0; i < OddNumber.Count; i++)
//                {
//                    Console.WriteLine(OddNumber[i]);
//                }
//                Console.ReadKey();
//            }
//        }
//    }
//    public class Number
//    {
//        //делай пока классы, поля класса, методы со словом public в начале
//        //int num;
//        //Список int'ов объявляется так: List<int> list = new List<int>();
//        // int list <OddNumbers>;
//        // int list <EventNumbers>;
//        //В метод должен передаваться параметр int i.
//        //Т.е. метод будет выглядеть так: public void Addnumber(int i) 

//        List<int> OddNumbers = new List<int>();
//        List<int> EventNumbers = new List<int>();
//        public void AddNumber()
//        {
//            for (int i = 0; i < 20; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    OddNumbers.Add(i);
//                }
//                else
//                {
//                    EventNumbers.Add(i);
//                }

//            }
//        }
//    }
//}
            
    
    
    
    //Triangle t1 = new Triangle(20,30);
            //Triangle t2 = new Triangle(10,12);

            //Circle circle = new Circle();
    //        List<Triangle> list1 = new List<Triangle>();
    //        List<Circle> list2 = new List<Circle>();
    //        List<Shape> listOfShapes = new List<Shape>();

    //        Shape shape1 = (Shape)t1;

    //        listOfShapes.Add(t1);
    //        listOfShapes.Add(circle);

    //        Circle circle1 = new Circle();
    //        Shape s = (Shape)circle1;//приравниваем значения ссылок. Т.е. 2 одинаковых числа - адреса, указывающих на
    //        //один участок в оперативной памяти. При этом нельзя создавать экземпляр Shape, т.к. он abstract
    //        Shape s1 = circle1;

    //        for (int i = 0; i < listOfShapes.Count; i++)
    //        {
    //            Console.WriteLine(listOfShapes[i].GetArea());
    //        }
    //        Console.ReadKey();


    //        list1.Add(t1);
    //        list1.Add(t2);
    //        for (int i=0;i<list1.Count;i++)
    //        {
    //            //Console.WriteLine(list1[i].GetArea());
    //            Console.WriteLine(list1[i].GetArea());
    //        }
    //        Console.ReadKey();

            
    //    }
    //}
    //{

    //        Matimatic.MetCompos();
    //        
    //    }
    //}

    //double[] values = new double[15];
    //int size = 20;
    //Car[] cars = new Car[size];
    //int speed = 0;
    //for (int i = 0; i < cars.Count(); i++)
    //{
    //    if (i % 2 == 0)
    //    {
    //        speed = 50;
    //        for (int j = 0; j < 1111; j++)
    //        {
    //            if
    //        }
    //    }
    //    else
    //    {
    //        speed = 0;
    //    }
    //    cars[i] = new Car(speed);
    //}

    //List<Car> cars2 = new List<Car>();
    //Car carElement1 = new Car(22);
    //cars2.Add(carElement1);

    //Car c = new Car();
    //TV tv = new TV();

    //List<ITurnOn> interfeisi = new List<ITurnOn>();
    //for (int i=0;i<interfeisi.Count;i++)
    //{
    //    interfeisi[i].TurnOn();
    //}
    //interfeisi.Add(c);

    //Deposit dep = new Deposit();
    //cars2.Add(dep);

    //for (int i = 0;i< 11;i++)
    //{
    //    Console.WriteLine(" Строка ");
    //}
    //Console.ReadKey();


    //Для вызова конструктора по умолчанию надо писать тоже (). Будет new Shape();
    //Shape Star1 = new Shape();
    //Rectangle rect = new Rectangle();
    //rect.Square = 20;

    //int sum;
    //sum = sum + 20;
    //sum += 20;
    //sum++;
    //++sum;
    //sum--;
    //sum *= 30;

    //int sum = 0;

    //for (1;2;3)
    //{
    //    strochka 1;
    //    string 2;

    //}

    //for (int i = 0; i < 11; i++)
    //{
    //    sum += i;

    //}
    //Console.WriteLine(sum);


    ////Для вызова методов без параметра надо писать после него (). Т.е. будет Star1.Draw()

    //Console.WriteLine(Star1.Draw);
    //Console.WriteLine(Star2.Draw);
    //    }
    //}
    //public class DeleteMe
    //{

    //}
    //public class Car : ITurnOn
    //{
    //    public int CurrentSpeed;
    //    public int Color;
    //    public Car() { }
    //    public Car(int speed)
    //    {
    //        CurrentSpeed = speed;
    //    }
    //}

    //public abstract class Shape
    //{
    //    public virtual double Square { get; set; }
    //    public double Perimetr;
    //    public double Color;


    //    public void Draw()
    //    {
    //        Perimetr = Square + 4;
    //    }
    //}
    //public class Rectangle : Shape
    //{
    //    //private double Sum;
    //    //public double GetSquare()
    //    //{
    //    //    return Square;
    //    //}
    //    //public void SetSquare(double value)
    //    //{
    //    //    if (value < 0)
    //    //        return;
    //    //    else
    //    //        Square = value;
    //    //}
    //    public override double Square { get; set; }
    //    {
    //        get { return Square; }
    //        set
    //        {
    //            Square = value * value;
    //        }
    //    }
    //    public int side;
    //    public int bisector;
    //    public int point;

    //    public void Draw()
    //    {
    //        Perimetr = Square + 2;
    //    }
    //}

    //public interface ITurnOn
    //{
    //    void TurnOn();
    //}
    //public class TV : ITurnOn // наследование
    //{

    //}


    //public class Deposit
    //{
    //    private double Sum;
    //    public double GetSum()
    //    {
    //        return Sum;
    //    }
    //    public void SetSum(double value)
    //    {
    //        Sum = value;
    //    }
    //    public void SubtractCash(double value)
    //    {
    //        if (value > Sum)
    //        {
    //            double diff = value - Sum;
    //            Sum = 0;
    //        }

    //12.03.2017 Сделать класс. В нём static метод. Вызвать из метода main этот созданный метод

    //public class Matimatic
    //{
    //    public int compos, i;

    ////Смотри. Т.к. статический метод вызывается без создания экземпляров, 
    //то этот метод не может видеть
    ////поля и методы, относящиеся к экземпляру класса. Т.е. из метода MetCompos 
    //ты можешь обращаться лишь к статическим полям или методам
    ////Я специально дал это задание чтобы ты увидел эти ошибки.
    ////Можешь почитать на msdn (в первую очередь) и ещё где нить про static слово
    ////Вкратце. Если у класса поле static, то это как бы общее для всех экземпляров 
    //данного класса значение данного поля.
    ////Например, класс - строитель. У него поле - начальник. Подразумеваем, что у 
    //всех работников на стройке один начальник. Тогда у каждого экземпляра класса 
    //    строитель будет static поле начальник
    ////И если его поменять на другого начальника, то он сменится у всех строителей. 
    //С методом примерно так же. Это действия выполняемые любым строителем независимо 
    //    от свойств (значений полей) отдельного строителя.
    ////И в этом методе можно использовать поля и другие методы, относящиеся только ко всем 
    // строителям (экземплярам класса), т.е. к static полям и методам.

    //public static void MetCompos()
    //{
    //    int tmp = 1;
    //    for (int i = 1; i < 20; i++)
    //    {
    //        tmp = tmp * i;  //почему не вижу метод 
    //                        //compos когда набираю Matimatic.       ?
    //    }
    //    //compos *= i;
    //    Console.WriteLine(tmp);
    //    Console.ReadKey();


//    public static class Matemath
//    {
//        static int count;
//        public static double Ymnog()
//        {
//            int tmp = 1;
//            for (int i = 1; i < 10; i++)
//            {
//                tmp = tmp * i;
//            }
//            return tmp;
//        }

//        public static double Summ()
//        {
//            int tmp = 1;
//            for (int i = 1; i < 10; i++)
//            {
//                tmp = tmp + i;
//            }
//            return tmp;
//        }



//        public static double Factory()
//        {
//            int tmp = 1;
//            for (int i = 1; i < 10; i++)
//            {
//                tmp = tmp * i;
//            }
//            return tmp;
//        }
//        // Console.WriteLine(Factory); //не видно Factory

//        //class Matemath = new Matemath();   
//        //     {    
//        //     Console.WriteLine(Matemath.Ymnog()); //почему не вижу методы после  Matemath. ?  
//        //     Console.WriteLine(Matemath.Summ());  
//        //     Console.WriteLine(Matemath.Factory());
//        //     Console.ReadKey();
//        //     }

//        //     class Matemath = new Matemath2();   // Задание в конструкторе присвоить count
//        //     {  


//        public static void IncreaseCount()
//        {
//            int count = 0;
//            count = count + 1;
//        }
//    }

//    public abstract class Shape
//    {
//        protected double Square;
//        public abstract double GetArea(); //virtual для переопределения 
//    }

//    public class Circle : Shape
//    {
//        private double radius = 3;
//        public override double GetArea() // override для переопределения
//        {
//            Square = Math.PI * radius * radius;
//            return Square;
//        }
//    }

//    public class Triangle : Shape
//    {
//        private double angle = 90;
//        private double A;
//        private double B;
//        public Triangle(double a,double b)
//        {
//            A = a;
//            B = b;
//        }
//        public override double GetArea()
//        {
//            Square = A * B / 2;
//            return Square;
//        }


//    }
//}



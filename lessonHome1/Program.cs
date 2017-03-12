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
            Matimatic.MetCompos();

        }
    }
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
    //public class TV : ITurnOn
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

    public class Matimatic
    {
        public int compos, i;

        //Смотри. Т.к. статический метод вызывается без создания экземпляров, то этот метод не может видеть
        //поля и методы, относящиеся к экземпляру класса. Т.е. из метода MetCompos ты можешь обращаться лишь к статическим полям или методам
        //Я специально дал это задание чтобы ты увидел эти ошибки.
        //Можешь почитать на msdn (в первую очередь) и ещё где нить про static слово
        //Вкратце. Если у класса поле static, то это как бы общее для всех экземпляров данного класса значение данного поля.
        //Например, класс - строитель. У него поле - начальник. Подразумеваем, что у всех работников на стройке один начальник. Тогда у каждого экземпляра класса строитель будет static поле начальник
        //И если его поменять на другого начальника, то он сменится у всех строителей. С методом примерно так же. Это действия выполняемые любым строителем независимо от свойств (значений полей) отдельного строителя.
        //И в этом методе можно использовать поля и другие методы, относящиеся только ко всем строителям (экземплярам класса), т.е. к static полям и методам.

        public static void MetCompos()
        {
            int tmp = 1;
            for (int i = 1; i < 20; i++)
            {
                tmp = tmp * i;  //почему не вижу метод 
                                //compos когда набираю Matimatic.       ?
            }
            //compos *= i;
            Console.WriteLine(tmp);
            Console.ReadKey();
        }
    }
}

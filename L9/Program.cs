using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9
{
    class Program
    {
        static void Main(string[] args)
        {
            //var Coords = new Coordinates(2,2,2);
            //(var x, var y, var z) = Coords;

            //var Answer = Math.Sqrt(Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)));

            //Console.WriteLine(Answer);

            //Today today = new Today();
            //(_, _, _, var hour, var minute, var second) = today;

            //Console.WriteLine(hour + " " + minute + " " + second);

            //P1();

            Console.ReadLine();
        }

        struct Coordinates
        {
            int X;
            int Y;
            int Z;

            public void Deconstruct(out int x, out int y, out int z)
            {
                x = X;
                y = Y;
                z = Z;
            }

            public Coordinates(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }
        }
        public static void P1()
        {
            Random rand = new Random();
            IFigure[,] figureArr = new IFigure[3,10];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 10; j++)
                {
                    switch (rand.Next(2))
                    {
                        case 0:
                            figureArr[i, j] = new Square(rand.Next(10), rand.Next(10));
                            break;

                        case 1:
                            figureArr[i, j] = new Triangle(rand.Next(10), rand.Next(10), rand.Next(10));
                            break;

                        case 2:
                            figureArr[i, j] = new Circle(rand.Next(10));
                            break;
                    }

                    Console.Write(figureArr[i, j].calculateArea() + " ");
                }
            }
        }
    }

    public class Today
    {
        public int Year = DateTime.Now.Year;
        public int Month = DateTime.Now.Month;
        public int Day = DateTime.Now.Day;
        public int Hour = DateTime.Now.Hour;
        public int Minute = DateTime.Now.Minute;
        public int Second = DateTime.Now.Second;

        public void Deconstruct(out int year, out int month,
                                    out int day, out int hours, out int minutes, out int seconds)
        {
            year = Year;
            month = Month;
            day = Day;
            hours = Hour;
            minutes = Minute;
            seconds = Second;
        }
    }

    public interface IFigure
    {
        double calculateArea();
    }

    public class Square : IFigure
    {
        public int x, y, area = 0;
        public double calculateArea()
        {
            return area = x * y;
        }

        public Square(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }
    }

    public class Triangle : IFigure
    {
        public int a, b, c, area = 0;
        public double calculateArea()
        {
            return area = a * b * c;
        }

        public Triangle(int A, int B, int C)
        {
            this.a = A;
            this.b = B;
            this.c = C;
        }
    }

    public class Circle : IFigure
    {
        double r;
        public double area = 0;
        public double calculateArea()
        {
            return area = 3.14 * r;
        }

        public Circle(double R)
        {
            this.r = R;
        }
    }
}

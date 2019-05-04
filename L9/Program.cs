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
            var Coords = new Coordinates(2,2,2);
            (var x, var y, var z) = Coords;

            var Answer = Math.Sqrt(Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)));

            Console.WriteLine(Answer);

            Today today = new Today();
            (_, _, _, var hour, var minute, var second) = today;

            Console.WriteLine(hour + " " + minute + " " + second);

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
}

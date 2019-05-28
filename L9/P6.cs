using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;

namespace L9
{
    class P6
    {
        public static void Task1()
        {
            while (true)
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine(DateTime.Now.Hour + " " + DateTime.Now.Minute + " " + DateTime.Now.Second);
            }
        }
    }
}

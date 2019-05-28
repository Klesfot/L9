using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L6;
using static L6.P6;

namespace L9
{
    class Program
    {
        public delegate string FormatString(string data);

        static void Main(string[] args)
        {
            FormatString del1 = new FormatString(ToUpperReg);
            FormatString del2 = new FormatString(SpacesTo_);

            List<string> dataSet = new List<string>();
            dataSet.Add("some string in lower");
            dataSet.Add(" ");
            dataSet.Add("SOME STRING IN UPPER");

            dataSet = dataSet.FormatStringFun(del1);
            dataSet = dataSet.FormatStringFun(del2);

            foreach (var item in dataSet)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static string ToUpperReg(string data)
        {
            return data.ToUpper();
        }

        public static string SpacesTo_(string data)
        {
            return data.Replace(" ", "_");
        }
    }
}

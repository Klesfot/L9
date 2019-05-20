using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9
{
    class P3_
    {
        public static void GuessType<T>(List<T> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] is string)
                {
                    string temp = items[i] as string;
                    if (temp.Count<char>() == 5)
                        Console.WriteLine("This is a string and it's count is 5");
                    else
                        Console.WriteLine("No clue");
                }

                else if (items[i] is int)
                {
                    if (Convert.ToInt32(items[i]) >= 0)
                        Console.WriteLine("This is an int and it's positive");
                    else
                        Console.WriteLine("No clue");
                }

                else if (items[i] is double)
                {
                    var temp = items[i].ToString();
                    temp = temp.Remove(0, temp.IndexOf(',') + 1);
                    if (temp.Length == 5)
                    {
                        Console.WriteLine("This is a float variable with 5 symbols after colon");
                    }
                    else
                        Console.WriteLine("No clue");
                }

                else if (items[i] is DateTime)
                {
                    Console.WriteLine("This is a date");
                }
            }
        }
    }

    interface IType
    {

    }
}

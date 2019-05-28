using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;
using static L9.Program;

namespace L6
{
    static class P6
    {
        public static List<string> FormatStringFun(this List<string> data, FormatString formatFun)
        {
            List<string> editedList = new List<string>();

            foreach (var item in data)
            {
                editedList.Add(formatFun(item));
            }

            return editedList;
        }
    }
}

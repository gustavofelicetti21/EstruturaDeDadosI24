using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Page
    {
        public string? Content { get; set; }


        public static string GetSpaces(int number)
        {
            string result = string.Empty;
            for (int i = 0; i < number; i++)
            {
                result += " ";
            }
            return result;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeHash
{
    public class Product
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public double Value { get; set; }

        

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
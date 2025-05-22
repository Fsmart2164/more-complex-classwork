using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linear_search
{
    internal class Program
    {
        static bool linear_sort(string[] array,string find)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (find == array[i])
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            string[] myStrings = new string[] { "john", "pork", "opsdofp", "jsdfjf", "fbvbv", "jsf" };
            bool inArray = linear_sort(myStrings, "pork");
        }
    }
}

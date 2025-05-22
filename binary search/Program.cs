using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search
{
    internal class Program
    {
        static void print(bool X)
        {
            if (X)
            {
                Console.WriteLine("True");
            }
            if (!X)
            {
                Console.WriteLine("false");
            }
        }
        static bool Binary_Sort(int[] array,int value)
        {
            int mid;
            int min = 0;
            int max = array.Length - 1;
            while (min < max)
            {
                mid = (min + max) / 2;

                if (array[mid] == value)
                {
                    return true;
                }
                else if (array[mid] > value)
                    max = mid;
                else if (array[mid] < value)
                    min = mid;
            }


            return false;
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            print(Binary_Sort(array,0));
            print(Binary_Sort(array, 1));
            print(Binary_Sort(array, 2));
            print(Binary_Sort(array, 3));
            print(Binary_Sort(array, 4));
            print(Binary_Sort(array, 5));

            Console.ReadKey();
        }
    }
}

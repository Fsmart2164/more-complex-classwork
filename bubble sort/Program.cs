using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort
{
    internal class Program
    {
        static void printList<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.Write(item);
                Console.Write(", ");
            }
            Console.WriteLine();

        }
        static void bubbleSort(List<int> ints)
        {
            bool swap = false;
            int temp;
            while (true)
            {
                for (int i = 0; i < ints.Count-1; i++)
                {
                    if (ints[i] > ints[i + 1])
                    {
                        temp = ints[i];
                        ints[i] = ints[i + 1];
                        ints[i + 1] = temp;
                        swap = true;
                    }
                }
                if (swap == false)
                {
                    break;
                }
                swap = false ;
                printList(ints);
            }
        }
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>() { 5 ,17, 2 ,6, 8, 9, 12, 7, 11,};
            Console.Write("unsorted list is:  ");
            printList(mylist);
            Console.WriteLine();

            bubbleSort(mylist);

            Console.WriteLine();
            Console.Write("sorted list is:  ");
            printList(mylist);
            Console.ReadKey();
        }
    }
}

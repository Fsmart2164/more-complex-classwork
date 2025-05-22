using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph_adjacency_matrix
{

    internal class Program
    {
        static int findindex(string name,List<string> names)
        {
            int i  = 0;
            foreach (string s in names)
            {
                if (name == s)
                {
                    return i;
                }
                i++;
            }
            return 100000;
        }
        static bool check_friendship(int p, int s, int[,] people)
        {
            if (people[p,s] == 1) return true;
            return false;
        }
        static void make_friends(int p, int s, int[,] people)
        {
            
                if (p == s)
                {
                    throw new Exception("mybartonexception");
                }
                people[p, s] = 1;
                people[s, p] = 1;
            
        }
        static void Main(string[] args)
        {
            List<string > names = new List<string>();
            names.Add("freddie");    //0
            names.Add("elias");      //1
            names.Add("gabe");       //2
            names.Add("eddie");      //3
            names.Add("jake");       //4

            int[,] people = new int[1000, 1000];
            make_friends(0,1,people);
            make_friends(0, 2, people);
            make_friends(1, 2, people);
            make_friends(0, 4, people);
            make_friends(2, 3, people);

            List<string> options = new List<string>();
            options.Add("check friendship");
            options.Add("make friends");
            options.Add("find index");
            options.Add("quit");

            bool endloop = false;
            while (!endloop)
            {
                switch (menu(options))
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("enter person 1: ");
                        int in1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter person 2: ");
                        int in2 = int.Parse(Console.ReadLine());
                        if (check_friendship(in1, in2, people) == true)
                        {
                            Console.WriteLine("they are friends");
                        }
                        else
                        {
                            Console.WriteLine("they arent friends");
                        }
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("enter person 1: ");
                        int p1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter person 2: ");
                        int p2 = int.Parse(Console.ReadLine());
                        make_friends(p1, p2, people);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("enter person name: ");
                        string input = Console.ReadLine();
                        Console.WriteLine("person is at " + findindex(input, names));
                        Console.ReadKey();
                        break;
                    case 3:
                        endloop = true;
                        break;
                }
            }


        }
        static int menu(List<string> options)
        {
            Console.Clear();
            int choice = 0;
            foreach (string s in options)
            {
                Console.Write(" ");
                Console.WriteLine(s);
            }
            Console.CursorLeft = 0;
            Console.CursorTop = 0;
            Console.Write(">");
            bool p = true;
            while (p == true)
            {
                    ConsoleKey input = Console.ReadKey(true).Key;
                    switch (input)
                {
                    case ConsoleKey.DownArrow:
                        if (Console.CursorTop < options.Count-1)
                        {
                            Console.CursorLeft = 0;
                            Console.Write(' ');
                            Console.CursorTop++;
                            Console.CursorLeft = 0;
                            Console.Write('>');
                            choice++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (Console.CursorTop > 0)
                        {
                            Console.CursorLeft = 0;
                            Console.Write(' ');
                            Console.CursorTop--;
                            Console.CursorLeft = 0;
                            Console.Write('>');
                            choice--;
                        }
                        break;
                    case ConsoleKey.Enter:
                        p = false;
                        break;
                }
            }
            return choice;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPN_with_stacks
{
    internal class Program
    {
        static double RPN(string[] values, Stack<double> Mystack)
        {
            foreach (string value in values)
            {
                if (value == "*")
                {
                    double y = Mystack.Pop();
                    double x = Mystack.Pop();
                    double z = x * y;
                    Mystack.Push(z);
                }
                else if (value == "/")
                {
                    double y = Mystack.Pop();
                    double x = Mystack.Pop();
                    double z = x / y;
                    Mystack.Push(z);
                }
                else if (value == "+")
                {
                    double y = Mystack.Pop();
                    double x = Mystack.Pop();
                    double z = x + y;
                    Mystack.Push(z);
                }
                else if (value == "-")
                {
                    double y = Mystack.Pop();
                    double x = Mystack.Pop();
                    double z = x - y;
                    Mystack.Push(z);
                }
                else if (value == "cos") 
                { 
                    double y = Mystack.Pop();
                    double z = Math.Cos(y);
                    Mystack.Push(z);
                }
                else if (value == "tan")
                {
                    double y = Mystack.Pop();
                    double z = Math.Tan(y);
                    Mystack.Push(z);
                }
                else if (value == "sin")
                {
                    double y = Mystack.Pop();
                    double z = Math.Sin(y);
                    Mystack.Push(z);
                }
                else if (value == "^")
                {
                    double y = Mystack.Pop();
                    double x = Mystack.Pop();
                    double z = Math.Pow(x,y);
                    Mystack.Push(z);
                }
                else
                {
                    double v = double.Parse(value);
                    Mystack.Push(v);
                }
            }
            return Mystack.Pop();
        }
        static string[] split_nospace(string input)
        {
            string[] split = new string[input.Length];
            for (int i = 0; i < split.Length; i++)
            {
                char s = input[i];
                string x = s.ToString();
                split[i] = x;
            }
            return split;
        }
        static string[] splitter(string str)
        {
            string[] parts = str.Split(' ');
            return parts;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("would you like spaces inbetween your RPN? y/n");
            string userin = Console.ReadLine();
            Console.WriteLine("enter RPN");
            string userinput = Console.ReadLine();
            if (userin == "y")
            {
                string[] values = splitter(userinput);
                Stack<double> Mystack = new Stack<double>(values.Length);
                double answer = RPN(values, Mystack);
                Console.WriteLine(answer);
                Console.ReadLine();
            }
            if (userin == "n")
            {
                string[] values = split_nospace(userinput);
                Stack<double> Mystack = new Stack<double>(values.Length);
                double answer = RPN(values, Mystack);
                Console.WriteLine(answer);
                Console.ReadLine();
            }
            
        }
    }
}

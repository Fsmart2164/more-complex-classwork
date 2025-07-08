using System;
using System.CodeDom.Compiler;
using System.Data.Odbc;
using System.Linq.Expressions;

namespace error_checking
{
    internal class Program
    {
        static void parity()
        {
            bool odd = false;
            Console.WriteLine("odd or even");
            string input = Console.ReadLine();
            if (input == "odd") odd = true;
            string bit = Console.ReadLine();
            if (checkifeven(bit) && !odd) Console.Write(1);
            else Console.Write(0);
            Console.WriteLine(bit);
        }
        static bool checkifeven(string bit)
        {
            bool check = false;
            // odd = false
            // even = true
            foreach (char c in bit)
            {
                if (c == '1') check = !check;
            }
            return check;
        }
        static bool paritycheck()
        {
            bool odd = false;
            Console.WriteLine("odd or even");
            string input = Console.ReadLine();
            if (input == "odd") odd = true;
            string data = Console.ReadLine();
            char bit = data[0];
            data = takeawaybit(data);
            bool iseven = checkifeven(data);
            if (whatshoulditbe(iseven,!odd) == bit) return true;
            return false;

        }
        static char whatshoulditbe(bool iseven, bool bittypeiseven)
        {
            if (iseven && bittypeiseven) return '0';
            if (!iseven && bittypeiseven) return '1';
            if (iseven && !bittypeiseven) return '1';
            if (!iseven && !bittypeiseven) return '0';
            throw new NotImplementedException();


        }
        static string takeawaybit(string input)
        {
            string temp = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (i != 0) temp+= input[i];
            }
            return temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Parity bit generation or majority voting or parity bit checking  \r\npg/mv/pc");
            string input = Console.ReadLine();
            if (input == "pg") parity();
            if (input == "mv") MajorityVoting();
            if (input == "pc") Console.WriteLine(paritycheck());
            Console.ReadKey();
        }
        static void MajorityVoting()
        {
            string i = Console.ReadLine();
            string n = Console.ReadLine();
            string p = Console.ReadLine();
            Console.WriteLine(cyclethrough(new string[] { i, n, p }));
        }
        static string cyclethrough(string[] ints)
        {
            string total = "";
            for (int i = 0; i < ints[0].Length; i++)
            {
                total += checkmostcommon(new char[] { ints[0][i], ints[1][i], ints[2][i] });
            }
            return total;
        }
        static char checkmostcommon(char[] ints)
        {
            if (ints[0] == ints[1])
            {
                return ints[0];
            }
            if (ints[1] == ints[2])
            {
                return ints[1];
            }
            if (ints[2] == ints[0])
            {
                return ints[2];
            }
            throw new Exception("error");
        }
    }
}

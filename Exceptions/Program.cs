using System;

namespace Exceptions
{
    public class DivideException : Exception
    {
        public DivideException() : base("division error")
        {

        }
    }
    public class SaveFileException : Exception
    {
        string savefilename;
        public SaveFileException(string savefilename) : base("There is an error with the save file "+filetype())
        {
            this.savefilename = savefilename;
            string name = getfilename();
        }
        private string getfilename()
        {
            return "john";
        }
        static private string filetype()
        {
            return ".txt";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Q1();
            //Q2();
        }
        static void Q2()
        {

        }
        static void Q1()
        {
            while (true)
            {

                try
                {
                    Console.WriteLine("enter two numbers to divide:");
                    int x = int.Parse(Console.ReadLine());
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine(divide(x, y));
                    break;
                }
                catch (DivideException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("error with inputting data");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }
        static int divide(int x, int y)
        {
            if (y == 0) throw new DivideException();
            return x / y;
        }
    }
}

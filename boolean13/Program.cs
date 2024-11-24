using System;
using static System.Console;

namespace boolean13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(ReadLine());
            int b = int.Parse(ReadLine());
            int c = int.Parse(ReadLine());
            
            bool result = a>0||b>0||c>0;
            WriteLine(result);
        }
    }
}
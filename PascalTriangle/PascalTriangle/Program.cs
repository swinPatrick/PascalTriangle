using System;
using System.Collections.Generic;
using System.Linq;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            while (userInput.ToLower() != "exit")
            {
                Program p = new Program();
                Console.WriteLine("How many lines to generate? (or 'exit') ");
                userInput = Console.ReadLine();
                try
                {
                    int lines = int.Parse(userInput);
                    p.GeneratePascalTriangle(lines);
                }
                catch
                {
                    Console.WriteLine("Input must be a number");
                }
            }
        }

        void GeneratePascalTriangle(int n)
        {
            int[] _previous = new int[n];
            int[] _current = new int[n];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                        _current[j] = 1;
                    else
                        _current[j] = _previous[j-1] + _previous[j];
                    Console.Write(_current[j] + " ");
                }
                Console.Write(Environment.NewLine);
                _current.CopyTo(_previous, 0);

            }
        }
    }
}

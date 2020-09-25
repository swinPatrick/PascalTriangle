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
            // you could also create a 2d array to store triangle for future use, but this seemed better for what is needed.
            int[] _previous = new int[n];
            int[] _current = new int[n];
            for(int i = 0; i < n; i++) // for each line
            {
                for(int j = 0; j <= i; j++) // for each element
                {
                    if (j == 0 || j == i) // first and last are always 1, prevents index error in else condition
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

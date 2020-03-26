using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                try
                {
                    Console.Write("Detect: ");
                    string detect = Console.ReadLine();
                    Console.WriteLine();

                    for (; ; )
                    {
                        Console.Write("Message: ");
                        string msg = Console.ReadLine();
                        Console.WriteLine($"Detected? {msg.Contains(detect)} \n");
                    }
                }

                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Whoops, something went wrong!");
                    Console.WriteLine(e);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }
    }
}

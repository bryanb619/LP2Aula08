using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace LINQFLuent
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            ReadFile();
        }

        private static void ReadFile()
        {
            try
            {
                IEnumerable<string> lines = File.ReadAllLines("text.txt");

                //int quanity = lines.Where(s=> s.Length > 30).Count();
                int quanity = lines.Count(s=> s.Length > 30);

                Console.WriteLine($"{quanity}");
                

                double avg = lines.Average(s => s.Length);

                Console.WriteLine($"{avg}");


                bool bigLine = lines.Any(s=> s.Length > 120);

                Console.WriteLine($"Has big line? {bigLine}");

                //IEnumerable<string> firstWY 
                //= lines.Where(s => s.Contains("Y"))
                //.Select(s=> s.Trim().Split()[0]);

                // query syntax
                IEnumerable<string> firstWY =
                    from s in lines
                    where s.Contains('Y')
                    select s.Trim().Split()[0];


                foreach (string s in firstWY)
                {
                    Console.WriteLine($"{s}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

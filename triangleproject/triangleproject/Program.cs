using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleproject
{
    class Program
    {



        public static int ProgramMenu()
        {
            string inputValue = string.Empty;
            bool ValidSelection = false;
            while (ValidSelection == false)
            {
                Console.WriteLine("1. Enter triangle dimentions.");
                Console.WriteLine(". Exit");
                inputValue = Console.ReadLine();
                if (inputValue != "1" && inputValue != "2")
                {
                    Console.WriteLine("\n");
                }
                else
                {
                    ValidSelection = true;
                }
            }
            Console.WriteLine();
            return int.Parse(inputValue);

            public string INVal()
            {
                int part1;
                int part2;
                int part3;

                Console.Write("Enter the first side of the triangle: ");
                part1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second side of the triangle: ");
                part2 = int.Parse(Console.ReadLine());

                Console.Write("Enter the third side of the triangle: ");
                part3 = int.Parse(Console.ReadLine());

                TriangleSolver.Analyze(part1, part2, part3);
            } }

           public static void Main(string[] args)
            {
               
    }
        
    } }

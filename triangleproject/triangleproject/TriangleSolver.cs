using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleproject
{
    public static class TriangleSolver
    {


        public static string Analyze(int part1, int part2, int part3)
        {
            string x = string.Empty;
            if (part1 + part2 > part3 && part2 + part3 > part1 && part1 + part3 > part2)
            {
                Console.WriteLine("Values you entered forms a triangle.");
            }
            else if (part1 == part2 && part2 == part3)
            {
                Console.Write("It is an equilateral triangle\n");
            }
            else if (part1 == part2 || part2 == part3 || part1 == part3)
            {
                Console.Write("It is an isosceles triangle\n");
            }
            else
            {
                Console.Write("It is an scalene triangle\n");
            }
            
        
            
            return x;
        }

    }
    } 

    


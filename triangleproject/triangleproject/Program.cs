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
                Console.WriteLine("2. Exit");
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
        }
        public static int getside(string s)
        {
            bool flag = true;
            int side = 0;
            while (flag)
            {
                Console.Write("Enter the {0} side of the triangle: ", s);
                bool result = int.TryParse(Console.ReadLine(), out side);
                if (result && side>0)
                {
                    flag = false;
                }
                if (side < 0)
                {
                    Console.WriteLine("entered value can not be less than zero");
                }
            }
            return side;
        }
        public static bool InVal()
        {
            bool flag = false;
            int side1 = getside("first");
            int side2 = getside("second");
            int side3 = getside("third");
            string type = TriangleSolver.Analyze(side1, side2, side3);
            if (type != "notTriangle")
            {              
                Console.WriteLine("Values you entered forms a triangle.");
                Console.WriteLine("The values you have entered  makes a {0} triangle", type);
            }
            else
            {             
                Console.WriteLine("The values does not make a triangle!");
                flag = true;
            }           
            return flag;
        }
        public static void Run()
        {
            int choice=ProgramMenu();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("");
                    bool repeat = InVal();
                    Run();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }           
        }
        public static void Main(string[] args)
        {
            Run();
        }
    }
}

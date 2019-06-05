using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleproject
{
    public static class TriangleSolver
    {

        
        public static string Analyze(int side1, int side2, int side3)
        {
            
            string meet = string.Empty;
          

             if (side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2)
            {
               
                if (side1 == side2 && side2 == side3)
                {
                    meet = "equilateral";
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    meet = "isoceles";
                }
                else 
                {
                    
                    meet = "scalene";
                }
            }

            else
            {
                meet = "notTriangle";
            }

           
            return meet;
        }

    }
}

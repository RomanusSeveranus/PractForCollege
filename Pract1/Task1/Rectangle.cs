using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Rectangle
    {
        private double side1; 
        private double side2; 

     
      
        public Rectangle(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;
        }

        
        private double AreaCalculator()
        {
            return side1 * side2;
        }

   
        private double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }

    
        public double Area
        {
            get { return AreaCalculator(); }
        }

   
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }
}

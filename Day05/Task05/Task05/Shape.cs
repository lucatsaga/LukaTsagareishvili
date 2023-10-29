using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    abstract class Shape
    {
        public abstract int Perimeter();
        public abstract double Area();
    }

    class Triangle : Shape
    {
        public int sideA { get; set; }
        public int sideB { get; set; }
        public int sideC { get; set; }
        public Triangle(int a, int b, int c)
        {
            sideA = a;
            sideB = b;
            sideC = c;

            if (sideA < 0 || sideB < 0 || sideC < 0)
            {
                throw new ArgumentException("samkutxedis gverdebi ver ikneba uaryofiti");
            }
            if (sideA >= (sideB + sideC) || sideB >= (sideA + sideC) || sideC >= (sideA + sideB))
            {
                throw new ArgumentException("samkutxedis ori gverdis jami yoveltvis meti unda iyos mesameze");

            }

        }
        public override int Perimeter()
        {
            int result = sideA + sideB + sideC;
            Console.WriteLine("perimetri- " + result);
            return result;
        }

        public override double Area()
        {
            double s = (sideA + sideB + sideC) / 2D;
            double result = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            Console.WriteLine("fartobi aris- " + result);
            return result;
        }
    }

    class Rectangle : Shape
    {
        public int width { get; set; }
        public int height { get; set; }

        public Rectangle(int a, int b)
        {
            width = a;
            height = b;


            if (width < 0 || height < 0)
            {
                throw new ArgumentException("otxkutxedis gverdebi ver ikneba uaryofiti");
            }

        }
        public override int Perimeter()
        {
            int result = 2 * (width + height);
            Console.WriteLine("perimetri aris- " + result);
            return result;
        }

        public override double Area()
        {
            double result = width * height;
            int result1 = Convert.ToInt32(result);
            Console.WriteLine("fartobi aris- " + result);
            return result;
        }


    }
    class Circle : Shape
    {
        public int radius { get; set; }

        public Circle(int a)
        {
            radius = a;



            if (radius < 0)
            {
                throw new ArgumentException("radiusi ver ikneba uaryofiti");
            }

        }
        public override int Perimeter()
        {
            int result = 2 * radius;
            Console.WriteLine("perimetri aris- " + result);
            return result;
        }
        public override double Area()
        {
            double result = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("fartobi aris- " + result);
            return result;
        }

    }
}
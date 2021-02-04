using System;

namespace TPSiK_lab_1
{
    public class Program
    {
        static public double getHypotenuse(double a, double b)
        {   if(a < 0 || b < 0)
            {
                throw new Exception("Invalid values");
            }
            double c = Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));
            return Math.Round(c, 2);
            
        }
        public static double getPerimeter(double a, double b, double c)
        {
            if(a < 0 || b < 0 || c < 0)
            {
                throw new Exception("Invalid values");
            }
            return a + b + c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть перший катет");
            string a1 = Console.ReadLine();
            int a = int.Parse(a1);
            Console.WriteLine("Введіть другий катет");
            string a2 = Console.ReadLine();
            int b = int.Parse(a2);
            double c = getHypotenuse(a, b);
            double per = getPerimeter(a, b, c);
            Console.WriteLine("Hypotenuse: " + c);
            Console.WriteLine("Perimeter: " + per);
            Console.ReadLine();

        }
    }
}

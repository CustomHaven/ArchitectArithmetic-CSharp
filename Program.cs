// https://www.codecademy.com/courses/learn-c-sharp/projects/csharp-architect-arithmetic
using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            // Q4 test cases
            // Console.WriteLine(Rect(4, 5));
            // Console.WriteLine(Circle(4));
            // Console.WriteLine(Triangle(10, 9));

            // Q5 
            /*
            So cost would be per area:
            rect is 2500 * 1500;
            triangle is 750 * 500;
            circle as its a half a circle we do
            PI * 375^2 then / 2; as it is half a circle
            */

            // Q6
            // double totalArea = Rect(2500, 1500) + Triangle(750, 500) + 0.5 * Circle(375);

            // Console.WriteLine(result);
            // Q7
            // double totalCost = totalArea * 180;
            // Q8
            //Console.WriteLine($"My plan costs: {totalCost} pesos");

            // Q9
            // Console.WriteLine($"My plan costs: {Math.Round(totalCost, 2)} pesos");

            // Q10 10a
            /*
            double totalAreaTM = Rect(90.5, 90.5) - 4 * Triangle(24, 24);
            double totalCostTM = totalAreaTM * 180;


            double totalAreaMasjidAlHaram = Rect(180, 106) + Rect(200, 264) + Triangle(264, 84);
            double totalCostFAKE = totalAreaMasjidAlHaram * 180;
            */
            // refined all the code block above so no repeat as this is training I will comment them all out.
            // Q10 10b is the way to quickly do it with the switch statement
            // Q10 10b 
            Console.WriteLine("What monument would you like to work with? ");
            Console.Write("Choose Masjid Al-Haram (1), Teotihuacan (2), or Taj Mahal (3). ");
            string monument = Console.ReadLine();
            double totalArea;

            switch (monument)
            {
                case "1":
                    totalArea = Rect(180, 106) + Rect(200, 264) + Triangle(264, 84);
                    break;
                case "2":
                    totalArea = Rect(90.5, 90.5) - 4 * Triangle(24, 24);
                    break;
                case "3":
                    totalArea = Rect(2500, 1500) + Triangle(750, 500) + 0.5 * Circle(375);
                    break;
                default:
                    totalArea = 0;
                    break;
            }


            double totalCost = totalArea * 180;

            Console.WriteLine($"The plan costs: {Math.Round(totalCost, 2)} pesos");

        }

        // Q1
        public static double Rect(double length, double width)
        {
            return length * width;
        }

        // Q2
        public static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        // Q3
        public static double Triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }

    }
}

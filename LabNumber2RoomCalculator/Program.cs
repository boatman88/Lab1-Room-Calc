using System;

namespace LabNumber2RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        { 
            string repeatCalculationInput = "";
            do
            {
                Console.WriteLine("Enter the length of the room in feet");
                string inputLength = Console.ReadLine();
                decimal length = decimal.Parse(inputLength);

                Console.WriteLine("Enter the width of the room in feet");
                string inputWidth = Console.ReadLine()
                decimal width = decimal.Parse(inputWidth);

                decimal area = length * width;
                decimal perimeter = 2 * length + 2 * width;
                Console.WriteLine(area);
                Console.WriteLine(perimeter);

                Console.WriteLine("Continue? y/n");
                repeatCalculationInput = (Console.ReadLine());


            } while (repeatCalculationInput != "n");
            
        }
    }
}
/*using System;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a Radius:");
            string input = Console.ReadLine();
            double radius = double.Parse(input);
            double pi = 3.14;
            double area = radius * radius * Math.PI;

            double circumference = 2 * radius * Math.PI;

            Console.WriteLine("Radius: " + radius);

            //String interpolation - a short for putting together strings using other variables
            Console.WriteLine($"Circumference: {circumference}");

            Console.WriteLine($"Area: {area}");
      
        }
    }
}*/

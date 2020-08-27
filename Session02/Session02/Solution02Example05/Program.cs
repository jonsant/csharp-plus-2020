using System;

namespace Solution02Example05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange vattentemperatur i grader C:");

            var input = Console.ReadLine();
            var integer = Convert.ToInt32(input);

            string waterLabel = integer >= 27 ? "Går att bada" : "Går inte att bada";

            // Är samma sak som
            //if (integer > 27)
            //{
            //    waterLabel = "Går att bada";
            //}
            //else
            //{
            //    waterLabel = "Går inte att bada";
            //}



            Console.WriteLine(waterLabel + " i havet");
        }
    }
}

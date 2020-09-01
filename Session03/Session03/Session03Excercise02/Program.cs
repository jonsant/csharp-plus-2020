using System;
using System.Collections.Generic;
using System.Linq;

namespace Session03Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konvertera det inmatade värdena från strängar till siffror
            // Resultatet skall presentera:
            // Lägsta värdet
            // Högsta värdet
            // Medelvärde (snitt)
            // Programmet skall vara felhanterat
            // Felaktiga värden får inte påverka medelvärde, lägsta eller högsta.

            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");
            var input = Console.ReadLine();
            var inputArray = input.Split(new [] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            int? average = null;
            int? maxValue = null;
            int? minValue = null;
            List<int> numbers = new List<int>();
            int[] intArray = new int[] { };

            for (int stringNum = 0; stringNum < inputArray.Length; stringNum++)
            {
                int number;
                if (Int32.TryParse(inputArray[stringNum], out number))
                {
                    numbers.Add(number);
                    sum += number;
                }
            }

            intArray = numbers.ToArray();

            try
            {
                maxValue = intArray.Max();
                minValue = intArray.Min();
                average = sum / intArray.Length;

            } catch (Exception e)
            {
                
            }

            Console.WriteLine($"\nNumber of values: {intArray.Length}");
            Console.WriteLine($"Max value: {maxValue}");
            Console.WriteLine($"Min value: {minValue}");
            Console.WriteLine($"Average: {average}");

        }
    }
}

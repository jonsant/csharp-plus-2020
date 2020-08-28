using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace Session03Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");
            var input = Console.ReadLine();

            var inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);

            double?[] numbersArray = new double?[inputArray.Length];
            double? sum = 0;
            double? largest = 0;
            double? smallest = 0;
            double? average = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                //try
                //{

                //    //Debug.Assert(i < inputArray.Length - 1);
                //}
                //catch (Exception)
                //{
                //    numbersArray[i] = 0;
                //}
                //finally
                //{

                //}

                NumberStyles numberStyle = NumberStyles.Integer | NumberStyles.Float;

                bool parsed = double.TryParse(inputArray[i], numberStyle, CultureInfo.InvariantCulture, out double parsedValue);

                if (parsed)
                {
                    numbersArray[i] = parsedValue;
                }
                else
                {
                    numbersArray[i] = null;
                }

                //numbersArray[i] = Convert.ToDouble(inputArray[i]);
                Console.WriteLine("Värde " + numbersArray[i]);

                //sum += numbersArray[i];

            }

            foreach (double? num in numbersArray)
            {
                if (num == null)
                {
                    continue;
                }
                else
                {
                    sum += num;
                }
            }

            largest = numbersArray.Max();
            smallest = numbersArray.Min();
            average = (float)sum / numbersArray.Length;

            // Option 2 for largest & smallest
            largest = numbersArray[0];
            smallest = numbersArray[0];

            foreach(double? num in numbersArray)
            {
                if (largest < num)
                    largest = num;

                if (smallest > num)
                    smallest = num;
            }


            Console.WriteLine($"\nStörsta värdet: {largest}\nLägsta värdet: {smallest}\n" +
                $"Antal tal: {numbersArray.Length}\nMedelvärde: {average}");

            //int exceptionStatus = getExceptionStatus();
        }

        //static double GetDoubleValue(string input)
        //{
        //    try
        //    {
        //        var result = int.Parse(input);

        //        return result;
        //    }
        //    catch (FormatException ex) when (ex.Message.Contains("Input string"))
        //    {
        //        //throw;
        //        return double.MinValue;

        //    }
        //    catch (Exception ex)
        //    {
        //        return 0;
        //    }
        //}

        //static int getExceptionStatus()
        //{
        //    int exceptionResult;

        //    try
        //    {
        //        exceptionResult = -1;

        //        throw new Exception("Provocerat fel");

        //        return exceptionResult;
        //    }
        //    catch (Exception ex)
        //    {
        //        exceptionResult = ex.HResult;

        //        return exceptionResult;

        //    }
        //    finally
        //    {
        //        exceptionResult = int.MaxValue;

        //    }
        // }
    }
}

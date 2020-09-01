using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace lek1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strängmanipulation

            string sentence = "   This is a sentence of text, it contains many words.    ";
            string inputData = "   ";

            // kolla om strängen är tilldelad ett värde
            bool inputIsNull = inputData == null;
            bool inputIsEmpty = inputData == string.Empty; // inputData == ""

            // snabbmetoder för att kontrollera innehållet i en sträng
            bool inputIsNullOrEmpty = string.IsNullOrEmpty(inputData);

            // ytterligare kontroller om strängen innehåller vettig data
            bool inputIsNullOrWhitespace = string.IsNullOrWhiteSpace(inputData);

            // trimma bort mellanslag och andra whitespace-tecken från början och slutet.
            string trimmedSentence = sentence.Trim();
            // trimma på slutet av strängen
            string endTrimmedSentence = sentence.TrimEnd();

            // det går att ange ett speciellt tecken som skall tas bort
            string punctuationTrimmedSentence = endTrimmedSentence.TrimEnd('.');

            string searchForWord = "text";
            int indexOfText = trimmedSentence.IndexOf(searchForWord);

            // hämta bara området som letas efter
            string hitSubString = trimmedSentence.Substring(indexOfText, searchForWord.Length);
            string beforeHitSubstring = trimmedSentence.Substring(0, indexOfText);

            // stora små bokstäver
            string uppercaseString = trimmedSentence.ToUpper();
            string lowercaseString = trimmedSentence.ToLower();

            // använder cultureinfo.invariantculture.
            // struntar i språkinställningar
            string uppercaseInvariantString = trimmedSentence.ToUpperInvariant();

            // komma åt ett enskilt tecken
            char oneCharacter = trimmedSentence[0];

            for (int i = 0; i < trimmedSentence.Length; i++)
            {
                // Loopa igenom en sträng, tecken för tecken.
                char currentCharacter = trimmedSentence[i];
            }

            foreach (var currentCharacter in trimmedSentence)
            {
                // Loopa igenom en sträng, tecken för tecken
                // här har man inte ett index
            }

            char[] trimmedSentenceCharArray = trimmedSentence.ToCharArray();

            // modifiera datat;

            trimmedSentence = new string(trimmedSentenceCharArray);

            trimmedSentence = trimmedSentence + "...";
            // samma sak som ovan
            // trimmedSentence += "...";

            // 1
            // 123
            // 2
            // 23
            // 3

            // 001
            // 002
            // 003
            // 023
            // 123

            var numberInString = "12";
            var paddedNumberInString = numberInString.PadLeft(3, '0');

            // Arrayer
            // Multidimensionella arrayer
            // en siffra för varje ruta
            int[,] chessBoard = new int[8, 8];

            // svartvit bild
            int width = 128;
            int height = 128;
            byte[,] blackWhiteImage = new byte[width, height];


            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    byte currentPixelValue = blackWhiteImage[x, y];
                }
            }

            // Tredimensionell data
            int size = 128;
            int[,,] voxelData = new int[size, size, size];

            for (var z = 0; z < size; z++)
            {
                for (var y = 0; y < size; y++)
                {
                    for (var x = 0; x < size; x++)
                    {
                        int currentVoxelValue = voxelData[x, y, z];
                    }
                }
            }

            // Uddasidiga (jagged) arrayer
            int[][] jaggedArray = new int[3][]
            {
                new int[] { 1, 3, 5 }, new int[] { 1, 4, 5}, new int[] { 9, 8, 7, 5, 6 }
            };

            // Tid och datum

            // Vad klockan är
            DateTime currentDateTime = DateTime.Now;
            // Oberoende av datorns tidsinställningar:
            DateTime currentTimeZoneNeutralDateTime = DateTime.UtcNow;

            // Kontrollera skottår
            DateTime.IsLeapYear(currentDateTime.Date.Year);

            // Maximala och minimala tiden
            DateTime maxValue = DateTime.MaxValue;
            DateTime minValue = DateTime.MinValue;

            // Hämta ut ett datum från en sträng
            var parsedDate = DateTime.Parse("2020-01-01");
            //DateTime failedParseDate = DateTime.Parse("asdf");

            // out-parameter sätter alltid värdet, parsedDate är ändrat
            // DateTime.TryParse fungerar på samma sätt som int.TryParse...
            bool dateWasParsed = DateTime.TryParse("asdf", out parsedDate);

            // Tiden
            TimeSpan currentTime = currentDateTime.TimeOfDay;
            // Baseras på ticks
            // currentTime.Ticks;

            // Hur många Ticks som går på en sekund
            // TimeSpan.TicksPerSecond;

            TimeSpan createdTimeSpan = new TimeSpan(1, 2, 3);

            Stopwatch timer = new Stopwatch();
            timer.Start();

            // Pausa programmet manuellt
            Thread.Sleep(1000);

            timer.Stop();

            DateTime today = DateTime.Today;
            DateTime yesterday = DateTime.Today.AddDays(-1)
                                                .AddSeconds(-1);

            TimeSpan resultOfTwoTimes = today - yesterday;
            TimeSpan negativeResultOfTwoTimes = yesterday - today;

            // Formattera datum
            // Console.WriteLine($"{currentDateTime:yyyy-MM-dd}");

            // Formattera datum på ett specifikt språk
            // Console.WriteLine(currentDateTime.ToString(CultureInfo.InvariantCulture));

            // Standardformattering (nuvarande språkinställningar)
            // Console.WriteLine(currentDateTime);

            // Formattera, skriva ut tid
            // Console.WriteLine($"{resultOfTwoTimes.ToString("hh:mm:ss"); (funkar inte, återkommer)

            // Slumpa värden
            Random randomizer = new Random();
            int randomNumber = randomizer.Next(0, 100);
            

        }

        static int GetSupportedLanguageIndex(string language)
        {
            string[] supportedLanguages = new string[] { "sv", "no", "dk" };
            //int languageIndexFromLoop = -1;

            for (int i = 0; i < supportedLanguages.Length; i++)
            {
                var currentLanguage = supportedLanguages[i];
                //if (currentLanguage != language)
                //    continue;

                //languageIndexFromLoop = i;
                //break;
                if (currentLanguage == language)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Session05Animals
{
    public class Chicken : Animal, IIBarnyardAnimal
    {
        private string _restingArea;
        private string _feedingArea;

        // => är en genväg för att skriva en get-instruktion
        public string RestingArea => _restingArea;
        
        // Genväg för att kalla på konstruktor i basklass
        public Chicken(int ageInYears) : base(ageInYears)
        {
        }

        // Egenskapsdefinition
        public string FeedingArea
        {
            get 
            {
                return _feedingArea;
            }
            set
            {
                _feedingArea = value;
            }
        }

        public override void EatFood()
        {
            /* Implementation av metoden */
            /* Fyller metoden med logik */
        }
    }
}

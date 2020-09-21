using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Session05Exercise01
{
    class CupOfCoffe
    {
        // Statiskt fält, delat för hela klassen.
        public static string DefaultBeanType = "Arabica";
        public static string[] BeanTypes;

        public string BeanType;
        public bool Instant;
        public bool Milk;
        public byte SugarCubes;
        public string Description;

        private string _id;

        // Statisk konstruktor
        static CupOfCoffe()
        {
            BeanTypes = new[]
            {
                "Arusha",
                "Arabica",
                "Blue Mountain",
                "Robusta"
            };
        }

        // Konstruktor
        // Identiskt namn med klassen
        public CupOfCoffe()
        {

        }

        // Konstruktor med inparamaterar
        public CupOfCoffe(bool milk, byte sugarCubes)
        {
            SugarCubes = sugarCubes;
            Milk = milk;
        }

        // Finalizer eller destruktor
        // Ej nödvändig om inte IDisposeable
        ~CupOfCoffe()
        {

        }
    }
}

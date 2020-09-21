using Session05Animals;
using System;

namespace Session05Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            var beanType = CupOfCoffe.DefaultBeanType;

            Animal myAnimal = new Chicken(1);
            myAnimal = new Cow(2);

            // Tvingad datakonvertering
            // Genererar InvalidCastException
            Cow myCow = (Cow)myAnimal;

            // Säker datakonvertering
            // Blir null om typen inte går att konvertera
            myCow = myAnimal as Cow;

            IIBarnyardAnimal myBarnyardAnimal = new Chicken(1);
            myBarnyardAnimal.FeedingArea = "Main yard";
            // myBarnyardAnimal.RestingArea = ""; går inte

            myAnimal = (Animal)myBarnyardAnimal;

            Chicken myChicken = new Chicken(1);

        }
    }
}

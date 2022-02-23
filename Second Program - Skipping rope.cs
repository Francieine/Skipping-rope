using System;

namespace Skipping_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemple how many calories I burn skippng rope//

            int weight;
            int time;
            int intensity;
            int results;


            Console.WriteLine("\t\t\t===============Calc to the Calories for the skipping rope=================\r");

            Console.WriteLine("\t\t\tType your weight in kg\r");
            weight = int.Parse(Console.ReadLine());

            Console.WriteLine("\t\t\tType your time of exercise\r");
            time = int.Parse(Console.ReadLine());

            Console.WriteLine("\t\t\tType your intensity in kg\r");
            intensity = int.Parse(Console.ReadLine());

            results = (weight + time + intensity) / 60;
            Console.WriteLine("Congratulations! Your caloric expenditure is:" + results);


            Console.ReadLine();
        }
    }
}

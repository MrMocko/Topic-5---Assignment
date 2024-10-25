namespace Topic_5___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        { // Andre
            Double earthWeight, planetWeight;
            string planet;



            Console.WriteLine("YOOOOOOO Julio Cesar Chavez Mark VII IS THAT REALY YOU, OMG, ok lets get to it.");
            Console.WriteLine("Oh ok well lets see how much you would weigh on different planets :)");
            Console.WriteLine("I can tell you how much you weigh on these few planets: ");
            Console.WriteLine();
            Console.WriteLine("1 - Venus, 2 - Mars, 3 - Jupiter, 4 - saturn, 5 - Uranus, 6 - Neptune.");
            Console.WriteLine();
            Console.Write("Please enter your current earth weight: ");
            double.TryParse(Console.ReadLine(), out earthWeight);
            Console.Write("Enter the planet here: ");
            planet = Console.ReadLine();
            if (planet == "1" || planet.ToLower() == "venus")
            {
                planetWeight = 0.78 * earthWeight;
                Console.WriteLine("Your weight would be: " + planetWeight);
            }
            else if (planet == "2" ||  planet.ToLower() == "Mars")
            {
                planetWeight = 0.39 * earthWeight;
                Console.WriteLine("Your weight would be: " + planetWeight);
            }
            else if (planetWeight == "3" || planet.ToLower() == "jupiter")
            {

            }

            
        }
    }
}

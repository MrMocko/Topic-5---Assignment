namespace Topic_5___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        { // Andre
            Double earthWeight, planetWeight;
            string planet;
            int secret, guess;



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
            else if (planet == "3" || planet.ToLower() == "jupiter") 
            {
                planetWeight = 2.65 * earthWeight;
                Console.WriteLine("Your weight would be: " + planetWeight);
            }
            else if (planet == "4" || planet.ToLower() == "saturn")
            {
                planetWeight = 1.17 * earthWeight;
                Console.WriteLine("Your weight would be: " + planetWeight);
            }
            else if (planet == "5" ||  planet.ToLower() == "uranus")
            {
                planetWeight = 1.05 * earthWeight;
                Console.WriteLine("Your weight would be: " + planetWeight);
            }
            else if (planet == "6" ||  planet.ToLower() == "neptune")
            {
                planetWeight = 1.23 * earthWeight;
                Console.WriteLine("Your weight would be: " + planetWeight);
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hey man lets play a guessing game.");
            Console.WriteLine("The number i have picked is between 1 - 10.");
            Console.WriteLine("Good luck");
            Console.Write("Enter your answer here: ");
            secret = 9;
            Int32.TryParse(Console.ReadLine(), out guess);
            if (guess == secret)
            {
                Console.WriteLine("Yea man good job you got it :)");

            }
            else
            {                
                Console.WriteLine("No you're wrong!!!");
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hey man lets do a quick quiz, if you don't mind?");


        }
    }
}

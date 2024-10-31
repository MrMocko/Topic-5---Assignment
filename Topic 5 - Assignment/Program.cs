using System.Diagnostics;

namespace Topic_5___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        { // Andre
            double earthWeight, planetWeight;
            string planet, brock, answer, princess, multChoiceAns;
            int secret, guess, pair, point =0;



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
            Console.WriteLine("");
            Console.WriteLine("Ok man how many shoes are in 10 pairs");
            Console.Write("Enter your answer here: ");
            Int32.TryParse (Console.ReadLine(), out pair);
            if (pair == 20 )
            {
                Console.WriteLine("");
                Console.WriteLine("Okkkkk okkkk man good work you got it right");
                point += 1;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Bro are you serious?");
            }
            Console.WriteLine("");
            Console.WriteLine("Ok next question");
            Console.WriteLine("");
            Console.WriteLine("What is Obama's last name?");
            Console.Write("Enter your answer here: ");
            brock = Console.ReadLine();
            if (brock.ToLower() == "obama")
            {
                Console.WriteLine("Oh yea man good job :)");
                point += 1;
            }
            else
            {
                Console.WriteLine("HAHA YOU ARE 100% WRONG!!!");
            }
            Console.WriteLine("");
            Console.WriteLine("Ok heres another question.");
            Console.WriteLine("");
            Console.WriteLine("Which Disney princess is known for her long, golden hair and a magical healing ability?");
            Console.WriteLine("\tA: Jasmine");
            Console.WriteLine("\tB: Rapenzel");
            Console.WriteLine("\tC: Snow White");
            Console.WriteLine("\tD: Mulan");
            Console.Write("Enter your answer here: ");
            answer = Console.ReadLine();
            if (answer.ToLower() == "a" || answer.ToLower() == "jasmine")
            {
                Console.WriteLine("Bruh... wrong");
            }
            else if (answer.ToLower() == "b" || answer.ToLower() == "rapeunzel")
            {
                Console.WriteLine("OMG YOU GOT IT RIGHT!");
                point += 1;
            }
            else if (answer.ToLower() == "c" || answer.ToLower() == "snow white")
            {
                Console.WriteLine("Wrong movie bucko AH AH AH ");
            }
            else if (answer.ToLower() == "d" || answer.ToLower() == "mulan")
            {
                Console.WriteLine("100% wrong on so many levels");
            }
            Thread.Sleep(1000);
            Console.WriteLine("Ok good job so far, heres the last question!!! GOOD LUCK!!!");
            Console.WriteLine("");
            Thread.Sleep(2000);
            Console.WriteLine("True or Flase is water wet?");
            Console.Write("Enter your answer here: ");
            multChoiceAns = Console.ReadLine();
            if (multChoiceAns.ToLower() == "f" ||  multChoiceAns.ToLower() == "false")
            {
                Console.WriteLine("YES GOOD JOB!!!!!");
                point += 1;
            }
            
            else
            {
                Console.WriteLine("You are 100% wrong on so many levels!!!");
            }
            Thread.Sleep(1000);
            Console.Write("Congrats you finished the quiz here is your score: " + point);
            Console.WriteLine(" Here is your final percentage.");
            Thread.Sleep(1500);
            if (point == 4)
            {
                Console.WriteLine("You got 100% Good job");
            }
            else if (point == 3)
            {
                Console.WriteLine("You got a 75%");
            }
            else if (point == 2)
            {
                Console.WriteLine("You got a 50% you are boarderline lucky");
            } 
            else if (point == 1)
            {
                Console.WriteLine("You got a 25% man you failed...");
            }
            else if (point == 0)
            {
                Console.WriteLine("Just leave please...");
            }
            Console.ReadLine();





        }
    }
}

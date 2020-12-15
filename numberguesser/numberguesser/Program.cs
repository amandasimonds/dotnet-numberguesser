using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberguesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //set vars
            string name = "manda";
            int age = 28;

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Amanda";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("Hello, " + name + "you are" + age);
            Console.WriteLine("{0} is {1}", name, age);

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset back to white
            Console.ResetColor();

            //Ask users name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play", inputName);

            while (true)
            {

                //Create a new random object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;

                Console.WriteLine("Guess a number between 1-10, {0}", inputName);

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    //make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("Please choose a NUMBER");
                        continue;
                    };

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong! GUess again");
                        Console.ResetColor();
                    }
                }

                //Output success
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Wooooo good job");
                Console.ResetColor();

                Console.WriteLine("Play again? Y or N");
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
    }
}

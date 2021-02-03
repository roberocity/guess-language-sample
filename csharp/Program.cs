using System;

namespace guess
{
    class Program
    {
        private readonly Random r = new Random();

        int ChooseNumberBetween(int min, int max) {
            return r.Next(min, max);
        }

        public void Run(int min, int max) {
            var number = ChooseNumberBetween(min, max);
            var guessCount = 0;

            Console.WriteLine("I have selected a number between {0} and {1}", min, max);
            Console.WriteLine("Please try to guess my number.");

            while(true) {
                Console.Write("Your guess: ");
                
                var guessStr = Console.ReadLine();
            
                if (!int.TryParse(guessStr, out int guess))
                {
                    Console.WriteLine("That doesn't appear to be a number. Try again.");
                    continue;
                }

                guessCount ++;
            
                if (guess == number)
                {
                    Console.WriteLine("You guessed my number in {0} guesses!", guessCount);
                    break;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Your guess was too low. Try again.");
                }
                else {
                    Console.WriteLine("Your guess is too high. Try again.");
                }
            }
        }

        static void Main(string[] args)
        {
            var min = 1;
            var max = 1000;

            if (args.Length > 0) {
                max = int.Parse(args[0]);
            }

            var p = new Program();
            p.Run(min, max);
        }
    }
}

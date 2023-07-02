using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guessing Game!");
            Console.WriteLine("You should guess the number, if your number was low, I say higher, and if it was a big number, I say Lower");
            Console.WriteLine("And if your number was right, you won!");
            Console.WriteLine("Choose a level:" + "Easy, Medium, Hard");

            string levelInput = Console.ReadLine();

                if (levelInput == "Easy")
                {
                    EasyLevel();
                }
                else if (levelInput == "Medium")
                {
                    MediumLevel();
                }
                else if (levelInput == "Hard")
                {
                    HardLevel();
                }
                else
                {
                    Console.WriteLine("The selected level is not valid");
        }

            Console.ReadLine();

        }

        static void EasyLevel()
        {


            bool isCorrectGuess = false;
            Random random = new Random();

            int RandomNum = random.Next(1, 11);


            while (!isCorrectGuess)
            {

                Console.WriteLine("Guess a number between 1 to 10");

                Console.WriteLine("Go!");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess > RandomNum)
                {
                    Console.WriteLine("Lower!");
                }
                else if (guess < RandomNum)
                {
                    Console.WriteLine("Higher!");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    isCorrectGuess = true;
                }
            }

            Console.WriteLine("Congratulations, You won this game!");
            Console.WriteLine("Programmer: Hesam Badamchi");

            Console.ReadKey();
        }

        static void MediumLevel()
        {

            bool isCorrectGuess = false;
            Random random = new Random();

            int RandomNum = random.Next(1, 16);


            while (!isCorrectGuess)
            {

                Console.WriteLine("Guess a number between 1 to 15");

                Console.WriteLine("Go!");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess > RandomNum)
                {
                    Console.WriteLine("Lower!");
                }
                else if (guess < RandomNum)
                {
                    Console.WriteLine("Higher!");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    isCorrectGuess = true;
                }
            }

            Console.WriteLine("Congratulations, You won this game!");
            Console.WriteLine("Programmer: Hesam Badamchi");

            Console.ReadKey();
        }
        
        static void HardLevel()
        {
            bool isCorrectGuess = false;
            Random random = new Random();

            int RandomNum = random.Next(1, 31);


            while (!isCorrectGuess)
            {

                Console.WriteLine("Guess a number between 1 to 30");

                Console.WriteLine("Go!");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess > RandomNum)
                {
                    Console.WriteLine("Lower!");
                }
                else if (guess < RandomNum)
                {
                    Console.WriteLine("Higher!");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    isCorrectGuess = true;
                }
            }

            Console.WriteLine("Congratulations, You won this game!");
            Console.WriteLine("Programmer: Hesam Badamchi");
        }

    }

}
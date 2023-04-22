using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        Random randomNumberGenerator = new Random();
        int randomNumber = randomNumberGenerator.Next(1,100);

        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int number = int.Parse(magicNumber);

        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();
        int guess = int.Parse(userGuess);

        int numberOfGuess = 1;

        while (randomNumber != guess)
        {
            if (randomNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (randomNumber < guess)
            {
                Console.WriteLine("Lower");
            }           

            Console.Write("What is your guess? ");
            userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            numberOfGuess++;

        }

        // if (number == guess)
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"It took you {numberOfGuess} guesses");        
        
        Console.Write("Do you want to play again (Yes or No)? ");
        string playAgain = Console.ReadLine();
        string lowerResponse = playAgain.ToLower();

        while (lowerResponse == "yes")
        {            
            randomNumber = randomNumberGenerator.Next(1,100);
            Console.Write("What is your guess? ");
            userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            numberOfGuess = 1;

            while (randomNumber != guess)
            {
                if (randomNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (randomNumber < guess)
                {
                    Console.WriteLine("Lower");
                }           

                Console.Write("What is your guess? ");
                userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);

                numberOfGuess++;

            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {numberOfGuess} guesses");
            Console.Write("Do you want to play again (Yes or No)? ");
            playAgain = Console.ReadLine();
            lowerResponse = playAgain.ToLower(); 
        }




        

       
    }
}
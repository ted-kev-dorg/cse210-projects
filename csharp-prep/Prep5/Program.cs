using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();

        string userName = PromptUserName ();
        int userNumber = PromptUserNumber ();


        int square = SquareNumber(userNumber);


        DisplayResult(userName, square);

    }

    static void DisplayWelcome ()
    {
    Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName ()
    {
        Console.Write("What's your name?: ");
        string userName = Console.ReadLine();

        return userName;       
    }

    static int PromptUserNumber ()
    {
        Console.Write("What's your favorites number?: ");
        string favoriteNumber = Console.ReadLine();
        int number = int.Parse(favoriteNumber);

        return number;       
    }

    static int SquareNumber(int userNumber)
    {
        int square = userNumber * userNumber;

        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name},  the square of your number is {square}");
       
    }

}

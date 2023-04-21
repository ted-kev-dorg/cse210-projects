using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        Console.Write("Enter your grade percentage: ");
        string userGradePercentage = Console.ReadLine();
        int gradePercentage = int.Parse(userGradePercentage);
        int remainder = gradePercentage % 10;
        
        string letter = "";
        string sign = "";

        if (gradePercentage >= 90)
        {
            // Console.WriteLine($"Your grade is A");
            letter = "A";
            
        }

        else if (gradePercentage >= 80)
        {
            // Console.WriteLine($"Your grade is B");
            letter = "B";
        }

        else if (gradePercentage >= 70)
        {
            // Console.WriteLine($"Your grade is C");
            letter = "C";
        }

        else if (gradePercentage >= 60)
        {
            // Console.WriteLine($"Your grade is D");
            letter = "D";
        }

        else if (gradePercentage < 60)
        {
            // Console.WriteLine($"Your grade is F");
            letter = "F";
        }

        // Finding the grade sign

        if (remainder >= 7)
        {
            sign = "+";
            
            if (letter == "A")
            {
                sign = "";
            }
            else if (letter == "F")
            {
                sign = "";
            }
        }
        else if (remainder < 3) 
        {
            sign = "-";

            if (letter == "F")
            {
                sign = "";
            }
        }
        
        Console.WriteLine($"Your grade is {letter}{sign}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Keep up the good work! Congratualtion you have passed");
        }
        else 
        {
            Console.WriteLine("Don't worry, you'll make next time, by Working a little bit harder.");
        }        

    }
}
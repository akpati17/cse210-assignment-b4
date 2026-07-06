
 using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        // Determine the letter grade
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign (+ or -)
        string sign = "";
        int lastDigit = grade % 10;

        if (letter != "F" && letter != "A")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A")
        {
            // A can only be A or A-
            if (lastDigit < 3 && grade < 100)
            {
                sign = "-";
            }
        }

        // Display the letter grade
        Console.WriteLine($"Your grade is {letter}{sign}.");

        // Determine if the student passed
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep working hard. You'll do better next time!");
        }
    }
}   

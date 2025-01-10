using System.Numerics;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Speedrun");
            Console.WriteLine("A variable is a named location in memory for storing data.");
            Console.WriteLine("Variables have a type, a name, and a value (contents).");
            Console.WriteLine("Variables are declared (created) like this: int number;.");
            Console.WriteLine("Assigning values to variables is done with the assignment operator: number = 3;.");
            Console.WriteLine("Using a variable name in an expression will copy the value out of the variable.");
            Console.WriteLine("Give your variables good names. You will be lad you did.");

            // Creating and using variables in C#
            string username;                        // Declaring a variable
            Console.Write("What is your username? ");
            username = Console.ReadLine();          // Assigning a value to a variable
            Console.WriteLine($"Hi {username}");    // Retrieving its curent value

            string favoriteColor;
            Console.Write("What is your favorite color? ");
            favoriteColor = Console.ReadLine();
            Console.WriteLine($"Hi {favoriteColor}");



            // Integers

            int score;
            score = 0;      // 0 is an int literal

            // Reading from a Variable Does not Change It

            int a;
            int b;

            a = 5;
            b = 2;

            b = a;
            a = -3;

            Console.WriteLine($"A = {a} and B = {b}");

            // Clever Variable Tricks

            int x = 0;              // Declare a variable and initialize on the same line
            int c, d, e;            // Declare multiple variables simultaneously
            int f = c = d = 10;     // Assign same thing to many variables all at once

            // Console.WriteLine() can display both strings and intergers:
            Console.WriteLine(42);

            // Variable Names
            /*
             1. Must start with a letter or the underscore
             2. After the start, you can also use numeric digits (0 through 9).
             3. Most symbols and whitespace characters are banned because they make it impossible for the compiler to konw where a variable name ends andother code begins.
             4. You cannot name a variable the same thing as a keyword.
            */
            
            // Variable guidelines
            /*
             1. Accurately describe what the variable holds. 
             2. Don't abbreviate or remove letters.
             3. Don't fret over long names.
             4. Names ending in numbers are a sign of poor names
             5. Avoid generic catch-all names.
             6. Make the boundaries between multi-word names clear
                - camelCase  (or lowerCamelCase) for variables
                - PascalCase (or UpperCamelCase) for other things            
             */



        }
    }
}

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Speedrun");
            Console.WriteLine("-- New projects usually begin life by being generated from a template. --");
            Console.WriteLine("-- A C# program starts running in the program's entry point or main method. --");
            Console.WriteLine("-- A full Hello World program looks like this: Console.WriteLine(\"Hello, World!\");");
            Console.WriteLine("-- Statements are single commands for the computer to perform. They run one after the next.");
            Console.WriteLine("-- Expressions allow you to define a value that is computed as the program runs from other elements.");
            Console.WriteLine("-- Variables let you store data for use later.");
            Console.WriteLine("-- Console.ReadLine() retrieves a full line of text that a user types from the console window.");

            Console.WriteLine();
            Console.WriteLine("Challenge - Hello, World! - 50XP");
            Console.WriteLine("Hello World");

            Console.WriteLine();
            Console.WriteLine("Challenge - What comes Next - 50XP");
            Console.WriteLine("C# is fun to learn");

            Console.WriteLine();
            Console.WriteLine("Challenge - The Makings of a Programmer - 50XP");
            Console.WriteLine("What is your name?");
            Console.WriteLine("What time is it?");
            Console.WriteLine("Where are we going?");
            Console.WriteLine("When will we eat?");
            Console.WriteLine("My name is Bob.");

            Console.WriteLine();
            Console.WriteLine("Challenge - Consolas and Telim - 50XP");
            Console.WriteLine("Bread is ready.");
            Console.Write("Who is the bread for? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Noted: {name} got bread.");
        }
    }
}

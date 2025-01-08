namespace Level_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Speedrun");
            Console.WriteLine("Comments let you put text in a program that the computer ignores.");
            Console.WriteLine("They can provide information to help programmers understand or remember what the code does.");
            Console.WriteLine("Anything after two slashes (//) on a line is a comment, as is anything between /* and */.");

            

            Console.WriteLine();
            Console.WriteLine("\"You gotta help me out!");

            Console.WriteLine("What kind of thing are we talking about?");
            // getting info from user set in variable a
            string a = Console.ReadLine();
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            // getting info from user set in variable b
            string b = Console.ReadLine();
            string c = "of Doom";
            string d = "3000";
            Console.WriteLine("The " + b + " " + a + " " + c + " " + d);



            
        }
    }
}

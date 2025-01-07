namespace ChallengeXpTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double xp = 0;
            Console.WriteLine("This will track your XP as you move along this book.");

            Console.WriteLine("Knowledge Check C#");
            Console.Write("True / False. C# is a special-purpose language optimized for making web applications.");
            string knowledgeCheck1 = Console.ReadLine().ToUpper();
            if (knowledgeCheck1 == "TRUE")
            {
               xp += 12.5;
            }
            Console.Write("What is the name of the framework that C# runs on?");
            string knowledgeCheck2 = Console.ReadLine().ToUpper();
            if(knowledgeCheck2 == ".NET")
            {
                xp += 12.5;
            }

            Console.WriteLine($"Your exp is now {xp}.");
        }
    }
}

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

            Console.WriteLine($"Your current experience points are {xp} and your current level is {lvl}");
            Console.WriteLine("");

            Console.WriteLine("Challenge #1");
            Console.WriteLine("Install Visual Studio");
            Console.WriteLine("75XP");
            Console.WriteLine("");

            Console.WriteLine("As your journey begins, you must get your tools ready to start programming in C#.");
            Console.WriteLine("Install Visual Studio 2022 Community edition (or another IDE) and get ready to start programming.");
            Console.Write("Have you downloaded an IDE (YES or NO?)");
            string challenge1 = Console.ReadLine().ToUpper();
            if (challenge1 == "YES")
            {
                xp += 75;
                Console.WriteLine($"That is correct! You have gained 75 experience points.");
            }
            else
            {
                Console.WriteLine("When you have installed your IDE let us know");
                Console.Write("YES?");
                challenge1 = Console.ReadLine().ToUpper();
                if(challenge1 == "YES")
                {
                    xp += 75;
                    Console.WriteLine($"That is correct! You have gained 75 experience points.");
                }
            }

            Console.WriteLine($"Your current experience points are {xp} and your current level is {lvl}");
            Console.WriteLine("");

            Console.WriteLine("Challenge #2");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("50XP");
            Console.WriteLine("");

            Console.WriteLine("You open your eyes and find yourself face down on the beach of a large island, the waves crashing on the shore not far off.");
            Console.WriteLine("A voice nearby calls out, \"Hey, you! You're finally awake!\"");
            Console.WriteLine("You sit up and look around. Somehow, opening your IDE has pulled you into the Realms of C#, a strange and mysterious land where it apears that you can use C# programming to solve problems.");
            Console.WriteLine("The man comes closer, examining you.");
            Console.WriteLine("\"Are you okay? Can you speak?\" Creating and running a \"Hello, World!\" program seems like a good way to respond. ");
            Console.WriteLine("");

            Console.WriteLine("Objectives:");
            Console.WriteLine("Create a new Hello World program from the C# Console Application template, targeting current .NET.");
            Console.WriteLine("Run your program using any of the three methods described");
            Console.WriteLine("");

            Console.Write("Have you completed the objective (Yes or No)");
            string challenge2 = Console.ReadLine().ToUpper();
            if (challenge2 == "YES")
            {
                xp += 50;
                Console.WriteLine($"That is correct! You have gained 50 experience points.");
            }
            else
            {
                Console.WriteLine("When you have installed your IDE let us know");
                Console.Write("YES?");
                challenge2 = Console.ReadLine().ToUpper();
                if (challenge2 == "YES")
                {
                    xp += 50;
                    Console.WriteLine($"That is correct! You have gained 50 experience points.");
                }
            }

            Console.WriteLine($"Your current experience points are {xp} and your current level is {lvl}");
            Console.WriteLine("");

            Console.WriteLine("Challenge #3");
            Console.WriteLine("What Comes Next");
            Console.WriteLine("50XP");
            Console.WriteLine("");

            Console.WriteLine("The man seems surprised that you've produced a working \"Hello, World!\" program.");
            Console.WriteLine("\"Been a while since I saw somebody program like that around here. Do you know what you're doing with that?\"");
            Console.WriteLine("\"Can you make it do something besides just say 'hello'?\"");

            Console.WriteLine("");
            Console.WriteLine("Objectives:");
            Console.WriteLine("Change your program to say somthing besides\"Hello, World!\"");
            Console.Write("Have you completed the objective (Yes or No)");
            string challenge3 = Console.ReadLine().ToUpper();
            if (challenge3 == "YES")
            {
                xp += 50;
                Console.WriteLine($"That is correct! You have gained 50 experience points.");
            }
            else
            {
                Console.WriteLine("When you have installed your IDE let us know");
                Console.Write("YES?");
                challenge3 = Console.ReadLine().ToUpper();
                if (challenge1 == "YES")
                {
                    xp += 50;
                    Console.WriteLine($"That is correct! You have gained 50 experience points.");
                }
            }

            Console.WriteLine($"Your current experience points are {xp} and your current level is {lvl}");
            Console.WriteLine("");

            Console.WriteLine("Challenge #4");
            Console.WriteLine("The Making of a Programmer");
            Console.WriteLine("50XP");
            Console.WriteLine("");

            Console.WriteLine("The man who tells you his name is Ritlin, asks you to follow him over to a few of his friends, fishing on the dock.");
            Console.WriteLine("\"This one here has the makings of a Programmer!\" Ritlin says. The group looks at you with eyes widening and mouths agape.");
            Console.WriteLine("Ritlin turns back to you and continues, \"I haven't seen nor heard tell of anybody who can wield that power in a million clock cycles of the CPU.\"");
            Console.WriteLine("\"Nobody has been able to do that since the Uncoded One showed up in thse lands.\" He describes the shadowy and mysterious Uncoded One, an evil power that rots programs and perhaps even the world itself.");
            Console.WriteLine("The Uncoded One's presence has prevented anybody from wielding the power of programming, the only thing that might be able to stop it.");
            Console.WriteLine("Yet somehow, you have been able to grab hold of this power anyway. Ritlin's companions suddenly seem doubtful.");
            Console.WriteLine("\"Can you show them what you showed me? Use some of that Programming of yours to make a program? Maybe something with more than one statement in it?\"");

            Console.WriteLine("");
            Console.WriteLine("Objectives:");
            Console.WriteLine("Make a program with 5 Console.WriteLine statements in it.");
            Console.Write("Have you completed the objective (Yes or No)");
            string challenge4 = Console.ReadLine().ToUpper();
            if (challenge4 == "YES")
            {
                xp += 25;
                Console.WriteLine($"That is correct! You have gained 25 experience points.");
            }
            else
            {
                Console.WriteLine("When you have installed your IDE let us know");
                Console.Write("YES?");
                challenge4 = Console.ReadLine().ToUpper();
                if (challenge1 == "YES")
                {
                    xp += 25;
                    Console.WriteLine($"That is correct! You have gained 25 experience points.");
                }
            }

            Console.Write("Answer this question: How many statements do you think a program can contain? (number answer)");
            int challenge4_1 = Convert.ToInt32(Console.ReadLine());
            if (challenge4_1 > 0)
            {
                xp += 25;
                Console.WriteLine($"That is correct! You have gained 25 experience points.");
            } else
            {
                Console.WriteLine($"That is wrong! The correct answer is more then 1. You gain 0 experience points.");
            }

            Console.WriteLine($"Your current experience points are {xp} and your current level is {lvl}");
            Console.WriteLine("");

        }
    }
}

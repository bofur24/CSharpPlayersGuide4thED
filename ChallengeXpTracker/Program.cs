namespace ChallengeXpTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Function needs made to calulate xp for lvl progression
            /* Level XP     Total    
            1 -> 2  200XP    200xp
            2 -> 3  400XP    600xp
            3 -> 4  600XP    1200XP
            4 -> 5  800XP    2000XP
            5 -> 6  1000XP   3000XP
            6 -> 7  1200XP   4200XP
            7 -> 8  1400XP   5600XP
            8 -> 9  1600XP   7200XP
            9 -> 10 1800XP   9000XP
            if (xp >= 199)
            {
               lvl = 1;
            }else if (xp >= 200 && xp <= 599 )
            {
                lvl = 2;
            }
            */

            double xp = 0;
            double lvl = 1;
            
            Console.WriteLine("This will track your XP as you move along this book.");
            Console.WriteLine();

            Console.WriteLine("Knowledge Check");
            Console.WriteLine("C#");
            Console.WriteLine("50XP");
            Console.WriteLine();

            

            Console.WriteLine("This will track your XP as you move along this book.");
            Console.WriteLine($"Your current exp is {xp} and your current level is {lvl}");
            Console.WriteLine("");

            Console.WriteLine("Knowledge Check #1");
            Console.WriteLine("C#");
            Console.WriteLine("25XP");
            Console.WriteLine("");


            Console.Write("True / False. C# is a special-purpose language optimized for making web applications.");
            string knowledgeCheck1 = Console.ReadLine().ToUpper();
            if (knowledgeCheck1 == "FALSE")


            {
                xp += 12.5;
                Console.WriteLine($"That is correct! You have gained 12.5 experience points.");
            }else

            {
                Console.WriteLine($"That is wrong! The correct answer is FALSE. You gain 0 experience points.");
            }
            Console.Write("What is the name of the framework that C# runs on?");
            string knowledgeCheck2 = Console.ReadLine().ToUpper();
            if(knowledgeCheck2 == ".NET")
            {
                xp += 12.5;
                Console.WriteLine($"That is correct! You have gained 12.5 experience points.");
            }
            else
            {
                Console.WriteLine($"That is wrong! The correct answer is .NET. You gain 0 experience points.");
            }

            Console.WriteLine();
            Console.WriteLine($"Your current experience points are {xp} and your current level is {lvl}");
            Console.WriteLine();

            Console.WriteLine("Challenge #1");
            Console.WriteLine("Install Visual Studio");
            Console.WriteLine("75XP");
            Console.WriteLine();

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

            Console.WriteLine();
            Console.WriteLine($"Your current experience points are {xp} and your current level is {lvl}");
            Console.WriteLine();

            Console.WriteLine("Challenge #2");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("50XP");
            Console.WriteLine();

            Console.WriteLine("You open your eyes and find yourself face down on the beach of a large island, the waves crashing on the shore not far off.");
            Console.WriteLine("A voice nearby calls out, \"Hey, you! You're finally awake!\"");
            Console.WriteLine("You sit up and look around. Somehow, opening your IDE has pulled you into the Realms of C#, a strange and mysterious land where it apears that you can use C# programming to solve problems.");
            Console.WriteLine("The man comes closer, examining you.");
            Console.WriteLine("\"Are you okay? Can you speak?\" Creating and running a \"Hello, World!\" program seems like a good way to respond. ");
            Console.WriteLine();

            Console.WriteLine("Objectives:");
            Console.WriteLine("Create a new Hello World program from the C# Console Application template, targeting current .NET.");
            Console.WriteLine("Run your program using any of the three methods described");
            Console.WriteLine();

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

            Console.WriteLine();
            Console.WriteLine($"Your current experience points are {xp} and your current level is {lvl}");
            Console.WriteLine();

            Console.WriteLine("Challenge #3");
            Console.WriteLine("What Comes Next");
            Console.WriteLine("50XP");
            Console.WriteLine();

            Console.WriteLine("The man seems surprised that you've produced a working \"Hello, World!\" program.");
            Console.WriteLine("\"Been a while since I saw somebody program like that around here. Do you know what you're doing with that?\"");
            Console.WriteLine("\"Can you make it do something besides just say 'hello'?\"");

            Console.WriteLine();
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
                Console.WriteLine("When you have completed the objective let us know");
                Console.Write("YES?");
                challenge3 = Console.ReadLine().ToUpper();
                if (challenge1 == "YES")
                {
                    xp += 50;
                    Console.WriteLine($"That is correct! You have gained 50 experience points.");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Your current experience points are {xp} and your current level is {lvl}");
            Console.WriteLine();

            Console.WriteLine("Challenge #4");
            Console.WriteLine("The Making of a Programmer");
            Console.WriteLine("50XP");
            Console.WriteLine();

            Console.WriteLine("The man who tells you his name is Ritlin, asks you to follow him over to a few of his friends, fishing on the dock.");
            Console.WriteLine("\"This one here has the makings of a Programmer!\" Ritlin says. The group looks at you with eyes widening and mouths agape.");
            Console.WriteLine("Ritlin turns back to you and continues, \"I haven't seen nor heard tell of anybody who can wield that power in a million clock cycles of the CPU.\"");
            Console.WriteLine("\"Nobody has been able to do that since the Uncoded One showed up in thse lands.\" He describes the shadowy and mysterious Uncoded One, an evil power that rots programs and perhaps even the world itself.");
            Console.WriteLine("The Uncoded One's presence has prevented anybody from wielding the power of programming, the only thing that might be able to stop it.");
            Console.WriteLine("Yet somehow, you have been able to grab hold of this power anyway. Ritlin's companions suddenly seem doubtful.");
            Console.WriteLine("\"Can you show them what you showed me? Use some of that Programming of yours to make a program? Maybe something with more than one statement in it?\"");

            Console.WriteLine();
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
                Console.WriteLine("When you have completed the objective let us know");
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

            Console.WriteLine() ;
            Console.WriteLine($"Your current experience points are {xp} and your current level is {lvl}");
            Console.WriteLine();

            Console.WriteLine("Challenge #5");
            Console.WriteLine("The Thing Namer 3000");
            Console.WriteLine("100XP");
            Console.WriteLine();

            Console.WriteLine("As you walk through the city of Commenton, admiring its forward-slash-based architectural buildings, a young man approaches you in a panic.");
            Console.WriteLine("\"I dropped my Thing Namer 3000 and broke it. I think it's mostly working, but all my variable names got reset! I don't understand what they do!\"");
            Console.WriteLine("He shows you the following program:");
            Console.WriteLine();

            Console.WriteLine("Console.WriteLine(\"What kind of thing are we talking about?\"");
            Console.WriteLine("string a = Console.ReadLine();");
            Console.WriteLine("Console.WriteLine(\"How would you describe it? Big? Azure? Tattered?\"");
            Console.WriteLine("string b = Console.ReadLine();");
            Console.WriteLine("string c = \"of Doom\";");
            Console.WriteLine("string d = \"3000\";");
            Console.WriteLine("Console.WriteLine(\"The \" + b + \" \" + a + \" of \" + c + \" \" + d + \"!\"");

            Console.WriteLine();
            Console.WriteLine("\"You gotta help me figure it out!\"");
            Console.WriteLine();

            Console.WriteLine("Objectives:");
            Console.WriteLine("Rebuild the program above on your computer.");
            Console.WriteLine("Add comments near each of the four variables that describe what they store. You must use at least one of each comment type (// and /* */).");
            Console.WriteLine("Find the bug in the text displayed and fix it.");
            Console.WriteLine();

            Console.Write("Have you completed the objective (Yes or No)");
            string challenge5 = Console.ReadLine().ToUpper();
            if (challenge5 == "YES")
            {
                xp += 25;
                Console.WriteLine($"That is correct! You have gained 25 experience points.");
            }
            else
            {
                Console.WriteLine("When you have completed the objective let us know");
                Console.Write("YES?");
                challenge5 = Console.ReadLine().ToUpper();
                if (challenge5 == "YES")
                {
                    xp += 25;
                    Console.WriteLine($"That is correct! You have gained 50 experience points.");
                }
            }

            Console.Write("Answer this question: Aside from comments, what else could you do to make this code more understandable?");
            string challenge5_1 = Console.ReadLine();
            if (challenge5_1 != " ")
            {
                xp += 25;
                Console.WriteLine($"That is correct! You have gained 50 experience points.");
            }
            else
            {
                Console.WriteLine($"That is wrong! You gain 0 experience points.");
            }

            Console.WriteLine();
            Console.WriteLine($"Your current experience points are {xp} and your current level is {lvl}");
            Console.WriteLine();









        }
    }
}

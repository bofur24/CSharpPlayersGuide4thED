namespace Type_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Speedrun");
            Console.WriteLine("Types of variables and values matter in C#. They are not interchangeable.");
            Console.WriteLine("There are eight interger types for storing intergers of differing sizes and ranges: int, short, long, byte, sbyte, uint, ushort and ulong.");
            Console.WriteLine("The char type stores single characters.");
            Console.WriteLine("The string type stores longer text.");
            Console.WriteLine("There are three types for storing real nubmers: float, double, and decimal.");
            Console.WriteLine("The bool type stores truth values (true and false) used in logic.");
            Console.WriteLine("There types are the building blocks of a much larger type system.");
            Console.WriteLine("Using var for a variable's type tells the compiler to infer its type from the surrounding code, so you do not have to type it out (But it still has a specific type.)");
            Console.WriteLine("The Convert class helps convert one type to antoher.");

            Console.WriteLine("Integer Types");
            Console.WriteLine();
            Console.WriteLine("Name\t\tBytes\t\tAllow Negatives\t\t\tMinimum\t\t\t\t\t\tMaximum");
            Console.WriteLine("byte\t\t1\t\tNo\t\t\t\t0\t\t\t\t\t\t255");
            Console.WriteLine("short\t\t2\t\tYes\t\t\t\t-32,768\t\t\t\t\t\t32,767");
            Console.WriteLine("int\t\t4\t\tYes\t\t\t\t-2,147,483,648\t\t\t\t\t2,147,483,648");
            Console.WriteLine("long\t\t8\t\tYes\t\t\t\t-9,223,372,036,854,775,808\t\t\t9,223,372,036,854,775,808");
            Console.WriteLine("sbyte\t\t1\t\tYes\t\t\t\t-128\t\t\t\t\t\t127");
            Console.WriteLine("ushort\t\t2\t\tNo\t\t\t\t0\t\t\t\t\t\t65,535");
            Console.WriteLine("uint\t\t4\t\tNo\t\t\t\t0\t\t\t\t\t\t4,294,967,295");
            Console.WriteLine("ulong\t\t8\t\tNo\t\t\t\t0\t\t\t\t\t\t18,446,744,073,709,551,615");
            Console.WriteLine();

            Console.WriteLine("Declaring and Using Variables with Integer Types");
            byte aSingleByte = 34;
            aSingleByte = 17;
            Console.WriteLine($"This is a singleByte {aSingleByte}");

            short aNumber = 5039;
            aNumber = -4354;
            Console.WriteLine($"This is a shortNumber {aNumber}");

            long aVeryBigNumber = 395904282569;
            aVeryBigNumber = 13;
            Console.WriteLine($"THis is a VeryBigNumber {aVeryBigNumber}");

            byte aNumberA = 32;
            long aVeryBigNumberA = 10000000000; // 10 billion would be a 'long' literal.
            ulong aVeryBigNumberB = 1000000000U; // U signifies that it is unsigned and must be either uint or ulong
            aVeryBigNumberB = 10000000000L; // L indicates that the literal must be a long or a ulong
            aVeryBigNumberB = 10000000000UL; // UL indicates that it must be a ulong

            Console.WriteLine();
            Console.WriteLine("The Digit Separator");
            int bigNumber = 1_000_000_000;
            Console.WriteLine(bigNumber);
            int a = 123_456_789;
            int b = 12_34_56_78_9;
            int c = 1_2__3___4____5;

            Console.WriteLine($"Digit Separator with Underscore {a}, {b}, {c}.");
            Console.WriteLine();

            Console.WriteLine("Choosing Between the Interger Types");
            Console.WriteLine("The more common strategy is to use int, uint, long or ulong as necessary.");
            Console.WriteLine("Only use byte, sbyte, short and ushort when there is a clear and significant benefit.");
            Console.WriteLine();

            Console.WriteLine("Binary and Hexadecimal Literals");
            Console.WriteLine("To write a binary literal, start your number with a 0b. For example:");
            int thirteen = 0b00001101;
            Console.WriteLine($"{thirteen} is 0b00001101");
            Console.WriteLine("For a hexadecimal literal, you start your number with 0x:");
            int theColorMagenta = 0xFF00FF;
            Console.WriteLine($"{theColorMagenta} is 0xFF00FF");
            Console.WriteLine();

            Console.WriteLine("Text: Characters and Strings");
            Console.WriteLine("A char literal is made by placing the character in single quotes:");
            char aLetter = 'a';
            Console.WriteLine($"This is a char {aLetter}");
            Console.WriteLine("If you know the hexadecimal Unicode number for a symbol and would prefer to use that, you can write that out after a \\u:");
            char aLettera = '\u0061'; // An 'a'
            Console.WriteLine($"\\u0061 is an {aLettera}");
            Console.WriteLine("A string literal is made by placing the desired text in double quotes:");
            string message = "Hello, World!";
            Console.WriteLine($"string mesage = \"{message}\"");





        }
    }
}

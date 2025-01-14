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
            Console.WriteLine();

            Console.WriteLine("Floating-Point Types");
            Console.WriteLine("Type\t\tByte\t\tDigits of Precision\t\tHardware Supported");
            Console.WriteLine("float\t\t4\t\t7\t\t\t\tYes");
            Console.WriteLine("double\t\t8\t\t15-16\t\t\t\tYes");
            Console.WriteLine("decimal\t\t16\t\t28-29\t\t\t\tNo");
            Console.WriteLine();
            double number1 = 3.5623;
            float number2 = 3.5623f;
            decimal number3 = 3.5623m;
            Console.WriteLine($"This is a double {number1}, this is a float {number2}, this is a decimal {number3}");
            Console.WriteLine();
            Console.WriteLine("Side Quest: Scientific Notation");
            double avogadrosNumber = 6.022e23;
            Console.WriteLine($"This is Avogadro's Number: {avogadrosNumber}");
            Console.WriteLine();
            Console.WriteLine("The Bool Type");
            Console.WriteLine("Bool has two options true and false");
            bool itWorked = true;
            bool itFailed = false;
            Console.WriteLine($"It worked = {itWorked}, it failed = {itFailed}");
            Console.WriteLine();

            Console.WriteLine("Challenge");
            Console.WriteLine("The Variable Shop");
            Console.WriteLine("100XP");
            Console.WriteLine();
            Console.WriteLine("You see an old shopkeeper struggling to stack up variables in a window display.");
            Console.WriteLine("\"Hoo-wee! All these variable types sure are exciting but seeting them all up to show them off to excited new programmers like yourself is a lot of work for these aching bones,\" she says.");
            Console.WriteLine("\"You wouldn't mind helping me set up this program with one variable of every type, would you?\"");
            Console.WriteLine();
            Console.WriteLine("Objectives:");
            Console.WriteLine("-Build a program with a variable of all fourteen types described in this level.");
            Console.WriteLine("-Assign each of them a value using a literal of the correct type.");
            Console.WriteLine("-Use Console.WriteLine to display the contents of each variable.");
            Console.WriteLine();

            byte byteType= 255;
            short shortType = 32_767;
            int intType = 2_147_483_647;
            long longType = 9_223_372_036_854_775_807;
            sbyte sbyteType = 127;
            ushort ushortType = 65_535;
            uint uintType = 4_294_967_295;
            ulong ulongType = 18_446_744_073_709_551_615;
            char charType = 'a';
            string stringType = "Hello World!";
            float floatType = 3.562f;
            double doubleType = 3.56231;
            decimal decimalType = 3.456789m;
            bool boolType = true;

            Console.WriteLine($" 1. byteType = {byteType}\n 2. shortType = {shortType}\n 3. intType = {intType}\n 4. longtype = {longType}\n 5. sbyteType = {sbyteType}\n 6. ushortType = {ushortType}\n " +
                $"7. uintType = {uintType}\n 8. ulongType = {ulongType}\n 9. charType = {charType}\n 10. stringType = {stringType}\n 11. floatType = {floatType}\n 12. doubleType = {doubleType}\n " +
                $"13. decimalType = {decimalType}\n 14. boolType = {boolType}.");

               










        }
    }
}

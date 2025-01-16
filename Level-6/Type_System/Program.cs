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
            Console.WriteLine();

            Console.WriteLine("Challenge");
            Console.WriteLine("The Variable Shop Returns");
            Console.WriteLine("50XP");
            Console.WriteLine();

            Console.WriteLine("\"Hey! Programmer!\" It's the shopkeeper from the Variable Shop who hobbles over to you.");
            Console.WriteLine("\"Thanks to your help, variables are selling like RAM cakes! But these people just aren't any good at programming. " +
                "They keep asking how to modify the values of the variables they're buying, and... well... frankly, I have no clue. But you're a programmer, right? " +
                "Maybe you could show me so I can show my customers?\"");
            Console.WriteLine();

            Console.WriteLine("Objectives:");
            Console.WriteLine("-Modify your Variable Shop program to assign a new, different literal value to each of the 14 original variables. Do not declare any additional variables.");
            Console.WriteLine("-Use Console.WriteLine to display the updated contents of each variable.");

            byteType = 254;
            shortType = 32_766;
            intType = 2_147_483_646;
            longType = 9_223_372_036_854_775_806;
            sbyteType = 126;
            ushortType = 65_534;
            uintType = 4_294_967_294;
            ulongType = 18_446_744_073_709_551_614;
            charType = 'b';
            stringType = "My name is";
            floatType = 3.561f;
            doubleType = 3.56230;
            decimalType = 3.456788m;
            boolType = false;

            Console.WriteLine();
            Console.WriteLine($" 1. byteType = {byteType}\n 2. shortType = {shortType}\n 3. intType = {intType}\n 4. longtype = {longType}\n 5. sbyteType = {sbyteType}\n 6. ushortType = {ushortType}\n " +
                $"7. uintType = {uintType}\n 8. ulongType = {ulongType}\n 9. charType = {charType}\n 10. stringType = {stringType}\n 11. floatType = {floatType}\n 12. doubleType = {doubleType}\n " +
                $"13. decimalType = {decimalType}\n 14. boolType = {boolType}.");
            Console.WriteLine();

            Console.WriteLine("Type Inference");

            var varMessage = "Hello, World!";
            // var x; DOES NOT COMPILE!
            Console.WriteLine($"This is a Type Inference using Var varMessage = {varMessage}");

            var something = "Hello";
            // something = 3; ERROR. Cannot store an int in a string-typed variable.

            Console.WriteLine();

            Console.WriteLine("The Convert Class and the Parse Methods");
            Console.WriteLine("What is your favorite number?");
            string favoriteNumberText = Console.ReadLine();
            int favoriteNumber = Convert.ToInt32(favoriteNumberText);
            Console.WriteLine($"My favorite number is {favoriteNumber}");
            Console.WriteLine();

            Console.WriteLine("Method Name\t\tTarget Type\t\t\tMethod Name\t\tTarget Type");
            Console.WriteLine("ToByte\t\t\tbyte\t\t\t\tToSByte\t\t\tsbyte");
            Console.WriteLine("ToInt16\t\t\tshort\t\t\t\tToUInt16\t\tushort");
            Console.WriteLine("ToInt32\t\t\tint\t\t\t\tToUInt32\t\tuint");
            Console.WriteLine("ToInt64\t\t\tlong\t\t\t\tToUInt64\t\tulong");
            Console.WriteLine("ToChar\t\t\tchar\t\t\t\tToString\t\tstring");
            Console.WriteLine("ToSingle\t\tfloat\t\t\t\tToDouble\t\tdouble");
            Console.WriteLine("ToDecimal\t\tdecimal\t\t\t\tToBoolean\t\tbool");
            Console.WriteLine();

            Console.WriteLine("Parse Methods");
            int number = int.Parse("9000");
            Console.WriteLine($"This is a string parsed to an int {number}");
            Console.WriteLine();

            Console.WriteLine("Knowledge Check");
            Console.WriteLine("Type System");
            Console.WriteLine("25XP");
            Console.WriteLine();

            Console.WriteLine("1. True/False. The int type can store any possible integer."); // False
            Console.WriteLine("2. Order the following by how large their range is, from smallest to largest: "); // byte, short, int, long
            Console.WriteLine("3. True/False. The byte type is signed."); // False
            Console.WriteLine("4. Which can store higher numbers, int or uint?"); // uint
            Console.WriteLine("5. What three types can store floating-point number?"); // float, double, decimal
            Console.WriteLine("6. Which of the options in question 5 can hold the largest numbers?"); // double
            Console.WriteLine("7. Which of the options in question 5 is the most precise?"); // decimal
            Console.WriteLine("8. What type does the literal value \"8\" (including the quotes) have?"); // string
            Console.WriteLine("9. What type stores true and false values?"); // bool












        }
    }
}

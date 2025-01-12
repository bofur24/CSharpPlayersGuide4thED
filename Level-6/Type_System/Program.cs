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

        }
    }
}

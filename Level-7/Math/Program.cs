namespace Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Level 7");
            Console.WriteLine("Math");
            Console.WriteLine();

            Console.WriteLine("Speedrun");
            Console.WriteLine("-Addition (+), subtraction (-), multiplication (*), division (/), and remainder (%) can all be used to do math in expressions: int a = 3 + 2 / 4 * 6;");
            Console.WriteLine("-The + and - operators can also be used to indicate a sign (or negate a value): +3, -2, or -a.");
            Console.WriteLine("-The order of operations matches the math world. Multiplication and division happen before addition and subtraction, and things are evaluated left to right.");
            Console.WriteLine("-Change the order by using parentheses to group things you want to be done first.");
            Console.WriteLine("-Compound assignment operators (+=, -=, *=, /=, %=) are shortcuts that adjust a variable with a math operation. a += 3; is the same as a = a + 3");
            Console.WriteLine("-The increment and decrement operators add and subtract one: a++; b--;");
            Console.WriteLine("-Each of the numeric types defines special values for their ranges (int.MaxValue, double.MinValue, etc.), and the floating-point types also define PositiveInfinity, NegativeInfinity, and NaN");
            Console.WriteLine("-Integer division drops remainders while floating-point division does not. Dividing by zero in either system is bad.");
            Console.WriteLine("-You can convert between types by casting: int x = (int)3.3;");
            Console.WriteLine("-The math and MathF classes contain a collection of utility methods for dealing with common math operations such as Abs for absolute value, Pow and Sqrt for powers and square roots, and Sin, Cos, and Tan for the trigonometry functions sine, cosine, and tangent, and a definition of (Math.PI)");
            Console.WriteLine();

            Console.WriteLine("Operations and Operators");
            Console.WriteLine("An operation is a calculation that takes (usually) two numbers and produces a single result by combining them somehow");
            Console.WriteLine("The things an operation uses -- the 2 and 3 in 2 + 3 are called operands.");
            int a = 2 + 3;
            Console.WriteLine($"int a = 2 + 3 is {a}");
            Console.WriteLine();

            Console.WriteLine("Addition, Subtraction, Multiplication, and Division");

            int b;              // Declaring the variable b.
            b = 9 - 2;          // Assigning a value to b, using some math.
            b = 3 + 3;          // Another assignment.

            int c = 3 + 1;      // Declaring c and assigning a value to c all at once
            c = 1 + 2;          // Assigning a second value to c

            Console.WriteLine($"B is {b}, C is {c}");
            Console.WriteLine();

            Console.WriteLine("Complex expressions with variables:");
            int d = 1;
            int e = d + 4;
            int f = d - e;
            Console.WriteLine($"int d ={d}, int e{e} = {d} + 4, f{f} = {d} - {e}");
            Console.WriteLine();

            Console.WriteLine("Multiplication uses the asterisk (*) symbol:");
            float totalPies = 4;
            float slicesPerPie = 8;
            float totalSlices = totalPies * slicesPerPie;

            Console.WriteLine($"TotalSlices {totalSlices} = totalPies {totalPies} * slicesPerPie {slicesPerPie}");
            Console.WriteLine();

            Console.WriteLine("Division uses the forward slash (/) symbol.");
            double moneyMadeFromGame = 100000;
            double totalProgrammers = 4;
            double moneyPerPerson = moneyMadeFromGame / totalProgrammers;

            Console.WriteLine($"moneyPerPerson {moneyPerPerson} = moneyMadeFromGame {moneyMadeFromGame} / totalProgrammers {totalProgrammers}");











        }
    }
}

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
            Console.WriteLine();

            Console.WriteLine("Compound expressions and Order of Operations");
            int result = 2 + 5 * 2;
            Console.WriteLine($"result = 2 + 5 * 2, result will be {result}");

            int result1 = (2 + 5) * 2;
            Console.WriteLine($"result1 = (2 + 5) * 2, result1 will be {result1}");

            int result2 = ((2 + 1) * 8 - (3 * 2) * 2) / 4;
            Console.WriteLine($"result2 = ((2 + 1) * 8 - (3 * 2) * 2) / 4, result2 will be {result2}");
            Console.WriteLine();

            Console.WriteLine("Area of a trapezoid");
            double side1 = 4.5;
            double side2 = 3.5;
            double height = 1.5;

            double areaOfTrapezoid = (side1 + side2) / 2.0 * height;
            Console.WriteLine($"Area of a Trapezoid = (side1({side1}) + side2({side2}) / 2.0 * height({height}), the result is {areaOfTrapezoid}");
            Console.WriteLine();

            Console.WriteLine("Challenge");
            Console.WriteLine("The Triangle Farmer");
            Console.WriteLine("100XP");
            Console.WriteLine();

            Console.WriteLine("As you pass through the fields near Arithmetica City, you encounter p-Thag, a triangle farmer, scratching numbers in the dirt.");
            Console.WriteLine("\"What is all of that writing for?\" You ask.");
            Console.WriteLine("\"I'm just trying to calculate the area of all my triangles. They sell by their size. The bigger they are, the more thye are worth!\"");
            Console.WriteLine("\"But I have many triangles on my farm, and the math get tricky, and I sometimes make mistakes. Taking a tiny triangle to town thinking you're going to get 100 gold,\"");
            Console.WriteLine("\"only to be told it's only worth three, is not fun! If only I had a program that could help me....\"");
            Console.WriteLine("Suddenly, P-Thag looks at you with fresh eyes.\"Wait just a moment. You have the look of a Programmer about you. Can you helpme write a program that will compute the areas for me, so I can quit worrying about math mistakes and get back to tending to my triangles?\"");
            Console.WriteLine("\"The equation I'm using is this one here,\" he says, pointing to the formula etched in a stone beside him:");
            Console.WriteLine();

            Console.WriteLine("Objectives:");
            Console.WriteLine("Write a program that lets you input the triangle's base size and height.");
            Console.WriteLine("Compute the area of a triangle by turning the above equation into code.");
            Console.WriteLine("Write the result of the computation.");

            Console.Write("What is the base of the triangle: ");
            int triangleBase = Convert.ToInt32( Console.ReadLine() );
            Console.Write("What is the height of the triangle: ");
            int triangleHeight = Convert.ToInt32( Console.ReadLine() );
            int area = triangleBase * triangleHeight / 2;
            Console.WriteLine($"The area of the triangle is {area}");
            Console.WriteLine();

            Console.WriteLine("Special Number Values");














        }
    }
}

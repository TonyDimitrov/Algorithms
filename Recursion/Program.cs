
namespace Recursion
{

    class Program
    {
        static void Main(string[] args)
        {
            var helper = new RecursionHelper();

            //  Console.WriteLine(helper.Sum(new int[] { 1, 2, 3, 4 }, 0));

            //  Console.WriteLine(helper.Factorial(5));

            //  helper.DrawFigure(5);

            // helper.GenVector(new int[3], 0);

            helper.GenCombinations(new int[] { 1, 2, 3 }, new int[2], 0, 0);
        }
    }
}

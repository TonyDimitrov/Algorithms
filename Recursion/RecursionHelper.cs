namespace Recursion
{
    using System;

    public class RecursionHelper
    {
        public int Sum(int[] numbers, int index)
        {
            if (numbers.Length == index)
            {
                return 0;
            }

            return Sum(numbers, index + 1) + numbers[index];
        }

        public long Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return Factorial(number - 1) * number;
        }

        /*
         Samply by given value 2
            **
            *
            #
            ##
         */
        public void DrawFigure(int n)
        {
            if (n == 0)
            {
                return;
            }

            Console.WriteLine(new string('*', n));

            DrawFigure(n - 1);

            Console.WriteLine(new string('#', n));
        }

        public void GenVector(int[] vector, int index)
        {
            if (vector.Length <= index)
            {
                Console.WriteLine(string.Join(" ", vector));

                return;
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    vector[index] = i;

                    GenVector(vector, index + 1);
                }
            }
        }

        public void GenCombinations(int[] set, int[] vector, int index, int offset)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
            }
            else
            {
                for (int i = offset; i < set.Length; i++)
                {
                    vector[index] = set[i];

                    GenCombinations(set, vector, index + 1, i + 1);
                }
            }
        }
    }
}

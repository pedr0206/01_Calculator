using System;

namespace _01_Calculator
{
    internal class Calculator
    {
        internal static int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        internal static int Subtract(int v1, int v2)
        {
            return v1 - v2;
        }

        internal static int Sum(int[] numbers)
        {
            int valorfinal = 0;
            foreach (int valor in numbers)
            {
               valorfinal = valorfinal + valor;

            }
            return valorfinal;
        }


        internal static int Multiply(int v1, int v2)
        {
            return v1 * v2;
        }

        internal static int Power(int v1, int v2)
        {
            int valorfinal = 1;
            for (int i = 1; i <= v2; i++)
            {
                valorfinal = valorfinal * v1;
            }
            return valorfinal;
        }

        internal static int Factorial(int v)
        {
            int valorfinal = 1;
            for (int i = 1; i <= v; i++)
            {
                valorfinal = valorfinal * i;
            }
            return valorfinal;
        }
    }
}
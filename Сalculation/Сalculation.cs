using System;

namespace Сalculation
{
    public static class Сalculation
    {
       public static double findSideOfTriangle(double P , double A)
       {
            if (P > 0 && A > 0 && A < P)
            {
                return (P - A) / 2;
            }
            return -1;
        }

        public static double findSumOfmembersSeries(int n , double x)
        {
            if (n <= 0)
            {
                return -1;
            }

            double S = 0;

            for (int i = 2; i <= n; i++)
            {
                S += Math.Cos(x) + (Math.Pow(Math.Cos(x), i) / i);
            }

            return S;
        }

        public static double findExactlySumOfmembersSeries(int n, double x)
        {
            
            if (n <= 0)
            {
                return -1;
            }

            double T = 0;
            double sum;
            double exact;

            for (int i = 2; i <= n; i++)
            {
                sum = 1 + 3 * Math.Pow(x, 2) + (5 * Math.Pow(x, 4) / Factorial(i)) + ((2*n + 1)/ Factorial(i)) * Math.Pow(x,2*i);
                exact = (1 - 2 * Math.Pow(x, 2)) * Math.Exp(Math.Pow(x, 2));
                T += (sum - exact) / exact * 1;

            }

            return T;
        }

        static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}

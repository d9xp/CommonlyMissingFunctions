using System;

namespace CommonlyMissingFunctions
{
    public static class MathExtensions
    {
        public static int Modulo (this int a, int n)
        {
            return (a - (int)Math.Floor((double)a / n) * n) % n;
        }

        public static int Grid (this int a, int n)
        {
            return (a / n).Modulo(n);
        }
    }
}

using System;

namespace CommonlyMissingFunctions
{
    public static class MathExtension
    {
        public static int Modulo (int a, int n)
        {
            return a - (int)Math.Floor((double)a / n) * n;
        } 
    }
}
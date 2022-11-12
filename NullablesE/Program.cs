using System;

namespace NullablesE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 1337;
            int num5;

            double? num3 = new Double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            Console.WriteLine("Our nullables numbers are: {0},{1},{2},{3}.", num1, num2, num3, num4);
            Console.WriteLine("The nullables boolean value is {0}.", boolval);

            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("\nUser is male.");
            }
            if (isMale == false)
            {
                Console.WriteLine("\nUser is female.");
            }
            else
            {
                Console.WriteLine("\nNo gender chosen.");
            }

            double? num6 = 13.1;
            double? num7 = null;
            double num8;

            if (num6 == null)
            {
                num8 = 0.0;
            }
            else
            {
                num8 = (double)num6;
            }

            // Shorter: THE NULL COALESCING OPERATOR ??
            num8 = num6 ?? 8.53;
            Console.WriteLine("\nValue of num8 is {0}.", num8);
            num8 = num7 ?? 8.53;
            Console.WriteLine("Value of num8 is {0}.", num8);
        }
    }
}

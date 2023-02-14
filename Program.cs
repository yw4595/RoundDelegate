using System;

namespace MathRoundDelegate
{
    // Author: [Your Name]
    // Purpose: Demonstrates the use of delegates to create a Math.Round method alternative.
    // Restrictions: None
    class Program
    {
        // Declares a delegate that has the same signature as Math.Round method
        public delegate double MyRoundDelegate(double value, int digits);

        static void Main(string[] args)
        {
            double originalDouble = 3.14159;

            // Round using Math.Round method
            double mathRoundResult = Math.Round(originalDouble);

            // Invoke delegate using the named method
            MyRoundDelegate myRound = new MyRoundDelegate(RoundToNearestInteger);
            double myRoundResult = myRound(originalDouble, 0);

            // Invoke delegate using an anonymous method
            MyRoundDelegate myRoundAnonymous = delegate (double value, int digits)
            {
                return (value >= 0) ? Math.Floor(value) : Math.Ceiling(value);
            };
            double myRoundAnonymousResult = myRoundAnonymous(originalDouble, 0);

            // Invoke delegate using lambda operator
            MyRoundDelegate myRoundLambda = (value, digits) => (value >= 0) ? Math.Floor(value) : Math.Ceiling(value);
            double myRoundLambdaResult = myRoundLambda(originalDouble, 0);

            // Invoke delegate using a generic template method
            Func<double, int, double> myRoundGeneric = RoundToNearestInteger;
            double myRoundGenericResult = myRoundGeneric(originalDouble, 0);

            // Print the results
            Console.WriteLine("Original double: " + originalDouble);
            Console.WriteLine("Rounded using Math.Round: " + mathRoundResult);
            Console.WriteLine("Rounded using delegate: " + myRoundResult);
            Console.WriteLine("Rounded using anonymous method: " + myRoundAnonymousResult);
            Console.WriteLine("Rounded using lambda operator: " + myRoundLambdaResult);
            Console.WriteLine("Rounded using generic template type: " + myRoundGenericResult);
        }

        /// <summary>
        /// Rounds the given value to the nearest integer.
        /// </summary>
        /// <param name="value">The value to round.</param>
        /// <param name="digits">The number of digits after the decimal point to round.</param>
        /// <returns>The rounded value.</returns>
        private static double RoundToNearestInteger(double value, int digits)
        {
            return (value >= 0) ? Math.Floor(value) : Math.Ceiling(value);
        }
    }
}

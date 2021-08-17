using System;

namespace FindMaximumNumberProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int output = MaximumNumberCheck.MaximumIntegerNumber(10,20,30);
            Console.WriteLine(output);

            double outputTwo = MaximumNumberCheck.MaximumFloatNumber(30.5, 30.6, 30.7);
            Console.WriteLine(outputTwo);

            string outputThreee = MaximumNumberCheck.MaximumStringNumber("22", "33", "44");
            Console.WriteLine(outputThreee);
        }

    }
}

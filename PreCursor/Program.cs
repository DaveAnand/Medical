using System;

namespace PreCursor 
{
    internal static class Program
    {
        private static void Main() 
        {
            //program go through the numbers 1 to 100 (inclusive)
            const int indexStart = 1;
            const int indexEnd = 100;

            const int modern = 3;
            const int medical = 5;

            for (int i = indexStart; i <= indexEnd; i++)
            {
                //If the number is divisible by 3
                if ((i % modern) == 0)
                {
                    //If the number is divisible by both 3 and 5, output  ModernMedical
                    if (i % medical == 0)
                        Console.WriteLine("ModernMedical");
                    else
                        // is only divisible by 3, output Modern
                        Console.WriteLine("Modern");
                }

                //If the number is divisible by 5 only, output Medical
                else if (i % medical == 0)
                    Console.WriteLine("Medical");
                else
                    Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
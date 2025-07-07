using System;

namespace Lab3Examples
{
    class ExceptionDemo
    {
        static void Main()
        {
            try
            {
                int a = 10, b = 0;
                int c = a / b;
                Console.WriteLine($"Result: {c}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }
    }
}
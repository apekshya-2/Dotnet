using System;

namespace Lab3Examples
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }

    class CustomExceptionDemo
    {
        static void ValidateAge(int age)
        {
            if (age < 18)
                throw new InvalidAgeException("Age must be at least 18.");
            Console.WriteLine("Age is valid.");
        }

        static void Main()
        {
            try
            {
                ValidateAge(15);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Custom Exception: {ex.Message}");
            }
        }
    }
}
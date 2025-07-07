using System;

namespace Lab3Examples
{
    // Define a delegate
    public delegate void Notify();

    class MulticastDelegateExample
    {
        static void MethodA()
        {
            Console.WriteLine("MethodA called.");
        }

        static void MethodB()
        {
            Console.WriteLine("MethodB called.");
        }

        static void Main()
        {
            Notify notify = MethodA;
            notify += MethodB; // Multicast

            notify(); // Calls both MethodA and MethodB
        }
    }
}
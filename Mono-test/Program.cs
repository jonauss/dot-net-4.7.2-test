using System;

namespace Mono_test
{
    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek enumValue = DayOfWeek.Monday;
            object value = (int)enumValue;
            try
            {
                var res = (DayOfWeek?)value; // Should throw
                Environment.Exit(1);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("This only compiles with Mono 5.14+.");
                Environment.Exit(0);
            }
        }
    }
}

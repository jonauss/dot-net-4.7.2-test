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
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("This is only reachable with Mono 5.14+.");
                return;
            }

            throw new Exception("This should be unreachable.");
        }
    }
}

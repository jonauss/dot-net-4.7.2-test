using System;
using System.Security.Cryptography;

namespace Mono_test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DSA dsa = DSA.Create(2048))
            {
                Console.WriteLine("This is a .NET 4.7.2 Application!");
                Console.WriteLine(dsa.GetHashCode());
            }
        }
    }
}

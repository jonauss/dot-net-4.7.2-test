using System;

namespace Mono_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var comm = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlAuthenticationMethod auth;
            var stringBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            Console.WriteLine("This only compiles with Mono 5.14+.");
        }
    }
}

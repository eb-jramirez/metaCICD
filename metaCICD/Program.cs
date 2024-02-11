using System;

namespace CiCdDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string environment = args[0];
            Console.WriteLine($"Deploying {environment} environment...");

            // Simulate deployment process
            System.Threading.Thread.Sleep(2000);

            // Print timestamp
            Console.WriteLine($"Environment {environment} deployed successfully at {DateTime.Now}");
        }
    }
}

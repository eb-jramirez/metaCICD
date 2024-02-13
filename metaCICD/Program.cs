using System;

namespace CiCdDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check if arguments are provided
            if (args.Length < 2)
            {
                Console.WriteLine("Usage: dotnet run <environment> <cluster> <service> <user> <kafka> <group> <k_cluster> <opensearch>");
                return;
            }

            // Extract parameters
            string environment = args[0];
            string cluster = args[1];
            string service = args[2];
            string user = args[3];
            string kafka = args[4];
            string group = args[5];
            string kCluster = args[6];
            string opensearch = args[7];

            Console.WriteLine($"Deploying {service} in {environment} environment...");
            Console.WriteLine($"Cluster: {cluster}");
            Console.WriteLine($"User: {user}");
            Console.WriteLine($"Kafka: {kafka}");
            Console.WriteLine($"Group: {group}");
            Console.WriteLine($"Kafka Cluster: {kCluster}");
            Console.WriteLine($"OpenSearch: {opensearch}");

            // Simulate deployment process
            System.Threading.Thread.Sleep(2000);

            // Print timestamp
            Console.WriteLine($"Service {service} deployed successfully at {DateTime.Now}");
        }
    }
}

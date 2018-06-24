using System;
using System.Collections.Generic;

namespace MinerTask
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var ResourceQuantity = GetResourcesQuantity(command);
            PrintResources(ResourceQuantity);
        }

        static void PrintResources(Dictionary<string, int> resourceQuantity)
        {
            foreach (var item in resourceQuantity)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }

        static Dictionary<string, int> GetResourcesQuantity(string command)
        {
            var MinerResources = new Dictionary<string, int>();

            while (command != "stop")
            {
                var resource = command;
                var quantity = int.Parse(Console.ReadLine());

                if (!MinerResources.ContainsKey(resource))
                {
                    MinerResources.Add(resource, quantity);
                }
                else
                {
                    MinerResources[resource] += quantity;
                }

                command = Console.ReadLine();
            }


            return MinerResources;
        }
    }
}

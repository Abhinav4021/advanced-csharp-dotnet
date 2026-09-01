using System.Reflection;

namespace Reflection.Attributes;

public static class AttributeReader
{
    public static void Run()
    {
        Console.WriteLine("=== Custom Attribute Reading ===");
        Type target = typeof(UserEndpoints);

        // Class-level attribute
        if (target.GetCustomAttribute<EndpointAttribute>() is { } classEndpoint)
        {
            Console.WriteLine($"Controller Route: [{classEndpoint.HttpMethod}] {classEndpoint.Route}");
        }

        // Method-level attributes
        MethodInfo[] methods = target.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        foreach (var method in methods)
        {
            if (method.GetCustomAttribute<EndpointAttribute>() is { } methodEndpoint)
            {
                Console.WriteLine($"  Action: {method.Name} -> [{methodEndpoint.HttpMethod}] {methodEndpoint.Route}");
            }
        }
    }
}
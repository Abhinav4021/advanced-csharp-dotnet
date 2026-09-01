using System.Reflection;
using System.Runtime.CompilerServices;
namespace Reflection.DynamicObjectCreation;

public static class ObjectFactory
{
    public static void Run()
    {
        Console.WriteLine("=== Dynamic Object Creation ===");
        Type type = typeof(ServiceClient);

        // 1. Activator with public parameterized constructor
        var client1 = (ServiceClient)Activator.CreateInstance(type, "https://api.domain.com", 60)!;
        Console.WriteLine($"Activator (Public): {client1}");

        // 2. Activator with private parameterless constructor
        var client2 = (ServiceClient)Activator.CreateInstance(type, nonPublic: true)!;
        Console.WriteLine($"Activator (Private): {client2}");

        // 3. Direct ConstructorInfo Invocation
        ConstructorInfo? ctor = type.GetConstructor(
            BindingFlags.Public | BindingFlags.Instance,
            binder: null,
            types: [typeof(string), typeof(int)],
            modifiers: null);

        var client3 = (ServiceClient)ctor!.Invoke(["https://custom.endpoint.com", 120]);
        Console.WriteLine($"ConstructorInfo.Invoke: {client3}");

        // 4. Uninitialized instance (bypasses all constructors)
        var client4 = (ServiceClient)RuntimeHelpers.GetUninitializedObject(type);
        Console.WriteLine($"Uninitialized: {client4}");
    }
}
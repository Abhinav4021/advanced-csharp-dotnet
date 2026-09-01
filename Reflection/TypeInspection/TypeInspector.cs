using System.Reflection;

namespace Reflection.TypeInspection;

public static class TypeInspector
{
    public static void Run()
    {
        Type type = typeof(Person);
        Console.WriteLine($"=== Type Inspection: {type.FullName} ===");

        // Inspect Interfaces & Base Types
        Console.WriteLine($"Base Type: {type.BaseType?.Name}");
        Console.WriteLine($"Is Class: {type.IsClass}, Is ValueType: {type.IsValueType}");

        // Inspect Properties (including non-public)
        Console.WriteLine("\n-- Properties --");
        PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        foreach (var prop in properties)
        {
            Console.WriteLine($"  {prop.PropertyType.Name} {prop.Name} (CanRead: {prop.CanRead}, CanWrite: {prop.CanWrite})");
        }

        // Inspect Methods (declaring type only)
        Console.WriteLine("\n-- Declared Methods --");
        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        foreach (var method in methods)
        {
            var parameters = string.Join(", ", method.GetParameters().Select(p => $"{p.ParameterType.Name} {p.Name}"));
            Console.WriteLine($"  {method.ReturnType.Name} {method.Name}({parameters})");
        }
    }
}
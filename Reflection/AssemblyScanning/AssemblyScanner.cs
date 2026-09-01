using System.Reflection;
namespace Reflection.AssemblyScanning;
public static class AssemblyScanner
{
    public static void Run()
    {
        Console.WriteLine("=== Assembly Scanning ===");
        Assembly currentAssembly = Assembly.GetExecutingAssembly();
        Type pluginInterface = typeof(IPlugin);

        // Discover all non-abstract classes implementing IPlugin
        var pluginTypes = currentAssembly.GetTypes()
            .Where(t => pluginInterface.IsAssignableFrom(t) && t is { IsInterface: false, IsAbstract: false })
            .ToList();

        Console.WriteLine($"Found {pluginTypes.Count} plugin(s):");
        foreach (var pluginType in pluginTypes)
        {
            var pluginInstance = (IPlugin)Activator.CreateInstance(pluginType)!;
            Console.Write($"  -> Running [{pluginInstance.Name}]: ");
            pluginInstance.Execute();
        }
    }
}
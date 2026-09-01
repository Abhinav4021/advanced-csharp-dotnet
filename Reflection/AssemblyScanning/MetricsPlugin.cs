
namespace Reflection.AssemblyScanning;

public class MetricsPlugin : IPlugin
{
    public string Name => "Metrics";
    public void Execute() => Console.WriteLine("Metrics reporting initialized.");
}
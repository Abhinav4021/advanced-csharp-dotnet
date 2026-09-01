
namespace Reflection.AssemblyScanning;

public interface IPlugin
{
    string Name { get; }
    void Execute();
}
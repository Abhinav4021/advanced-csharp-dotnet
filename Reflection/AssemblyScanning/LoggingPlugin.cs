public class LoggingPlugin : IPlugin
{
    public string Name => "Logger";
    public void Execute() => Console.WriteLine("Logging initialized.");
}
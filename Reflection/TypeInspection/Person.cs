using System.Reflection;

namespace ReflectionDemo.TypeInspection;

public record Person(string Name, int Age)
{
    private string SecretCode => $"{Name}_42";

    public void Greet() => Console.WriteLine($"Hi, I'm {Name}");
}
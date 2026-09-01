using ReflectionDemo.TypeInspection;
using ReflectionDemo.Attributes;
using ReflectionDemo.DynamicObjectCreation;
using ReflectionDemo.MethodInvocation;
using ReflectionDemo.AssemblyScanning;

Console.WriteLine("##########################################");
Console.WriteLine("#        C# Reflection Playground        #");
Console.WriteLine("##########################################\n");

TypeInspector.Run();
Console.WriteLine("\n------------------------------------------\n");

AttributeReader.Run();
Console.WriteLine("\n------------------------------------------\n");

ObjectFactory.Run();
Console.WriteLine("\n------------------------------------------\n");

MethodInvoker.Run();
Console.WriteLine("\n------------------------------------------\n");

AssemblyScanner.Run();
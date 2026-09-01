using Reflection.TypeInspection;
using Reflection.Attributes;
using Reflection.DynamicObjectCreation;
using Reflection.MethodInvocation;
using Reflection.AssemblyScanning;

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
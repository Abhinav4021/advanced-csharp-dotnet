public static class MethodInvoker
{
    public static void Run()
    {
        Console.WriteLine("=== Method Invocation ===");
        var calc = new Calculator();
        Type type = calc.GetType();

        // 1. Invoke public instance method
        MethodInfo addMethod = type.GetMethod(nameof(Calculator.Add))!;
        object? sumResult = addMethod.Invoke(calc, [15, 27]);
        Console.WriteLine($"Public Add(15, 27) = {sumResult}");

        // 2. Invoke private method
        MethodInfo mulMethod = type.GetMethod("MultiplyHidden", BindingFlags.NonPublic | BindingFlags.Instance)!;
        object? mulResult = mulMethod.Invoke(calc, [3.5, 4.0]);
        Console.WriteLine($"Private MultiplyHidden(3.5, 4.0) = {mulResult}");

        // 3. High-performance compiled delegate invocation (avoids boxing overhead in loops)
        var fastAdd = (Func<int, int, int>)Delegate.CreateDelegate(typeof(Func<int, int, int>), calc, addMethod);
        int fastResult = fastAdd(50, 50);
        Console.WriteLine($"Delegate.CreateDelegate Add(50, 50) = {fastResult}");
    }
}
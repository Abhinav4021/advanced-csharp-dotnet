
namespace Reflection.MethodInvocation;

public class Calculator
{
    public int Add(int a, int b) => a + b;
    private double MultiplyHidden(double x, double y) => x * y;
}

namespace Reflection.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
public sealed class EndpointAttribute : Attribute
{
    public string Route { get; }
    public string HttpMethod { get; }

    public EndpointAttribute(string route, string httpMethod = "GET")
    {
        Route = route;
        HttpMethod = httpMethod;
    }
}
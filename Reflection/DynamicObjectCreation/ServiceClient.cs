
namespace Reflection.DynamicObjectCreation;

public class ServiceClient
{
    public string Endpoint { get; }
    public int Timeout { get; }

    public ServiceClient(string endpoint, int timeout)
    {
        Endpoint = endpoint;
        Timeout = timeout;
    }

    private ServiceClient()
    {
        Endpoint = "http://internal.default";
        Timeout = 30;
    }

    public override string ToString() => $"ServiceClient(Endpoint={Endpoint}, Timeout={Timeout})";
}
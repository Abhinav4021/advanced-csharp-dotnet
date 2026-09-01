namespace Reflection.Attributes;

[Endpoint("/api/users")]
public class UserEndpoints
{
    [Endpoint("/details", "POST")]
    public void GetUserDetails() { }
}
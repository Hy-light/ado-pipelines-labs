namespace CloudLaunch.Api.Services;

public class GreetingService
{
    public string Greet(string? name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name must be a non-empty string", nameof(name));
        }
        return $"Hello, {name}!";
    }

    public int Add(int a, int b) => a + b;
}
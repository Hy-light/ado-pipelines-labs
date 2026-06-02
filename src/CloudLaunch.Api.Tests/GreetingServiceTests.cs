using CloudLaunch.Api.Services;
using Xunit;

namespace CloudLaunch.Api.Tests;

public class GreetingServiceTests
{
    private readonly GreetingService _sut = new();

    [Fact]
    public void Greet_ReturnsHelloMessage()
    {
        Assert.Equal("Hello, Prince!", _sut.Greet("Prince"));
    }

    [Fact]
    public void Greet_ThrowsOnEmpty()
    {
        Assert.Throws<ArgumentException>(() => _sut.Greet(""));
    }

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-1, 1, 0)]
    [InlineData(0, 0, 0)]
    public void Add_SumsTwoNumbers(int a, int b, int expected)
    {
        Assert.Equal(expected, _sut.Add(a, b));
    }
}
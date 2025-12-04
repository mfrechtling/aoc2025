using hello.world; // Reference your main application's namespace

[TestFixture]
public class GreetingTests
{
    [Test] // NUnit uses [Test] instead of xUnit's [Fact]
    public void GenerateGreeting_ReturnsExpectedString()
    {
        // Arrange
        var generator = new GreetingGenerator();
        var expected = "Hello, World!";

        // Act
        var actual = generator.GenerateGreeting();

        // Assert options:
        // Option A: Classic NUnit assertion
        Assert.That(expected == actual);

        // Option B: NUnit constraint model (more flexible for complex checks)
        // Assert.That(actual, Is.EqualTo(expected));
    }

    // You can add a second test that fails on purpose to test CI failure conditions
    [Test, Ignore("Used only to test CI failure conditions if needed\n")]
    public void FailsOnPurpose()
    {
        Assert.That(false, "This test is designed to fail.");
    }
}

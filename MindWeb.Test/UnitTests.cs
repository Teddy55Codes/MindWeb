namespace MindWeb.Test;

public class UnitTests
{
    [Test]
    public async Task MyTest()
    {
#pragma warning disable TUnitAssertions0005
        await Assert.That(1).IsEqualTo(1);
#pragma warning restore TUnitAssertions0005
    }
}
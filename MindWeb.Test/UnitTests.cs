namespace MindWeb.Test;

public class UnitTests
{
    [Test]
    public async Task MyTest()
    {
        await Assert.That(1).IsEqualTo(1);
    }
}
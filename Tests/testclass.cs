namespace bulkybook.Tests;
using Xunit;
public class testclass {
    [Fact]
    public void PassingTest()
    {
        Assert.Equal(4, 2+2);
    }
    [Fact]
    public void FailingTest()
    {
        Assert.Equal(4,5);
    }
}
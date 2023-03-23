using Xunit.Abstractions;

namespace xunittryout;

public class UnitTest1 : IDisposable
{
    private readonly ITestOutputHelper _testOutputHelper;
    private int _a = 1;

    public UnitTest1(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
        _a++;
    }

    [Fact]
    public void Test1()
    {
        Assert.Equal(2, _a);
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(3, ++_a);
    }

    public void Dispose()
    {
        _a = 0;
        _testOutputHelper.WriteLine($"after-dispose: {_a}");
    }
}

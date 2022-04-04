using Xunit;
namespace BL;
using Models;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(4, (2 + 2));
    }

    User someUser = new User();
    [Fact]
    public void Test2()
    {
        Assert.Equal("Default", someUser.getUsername());
    }
}
namespace Snoopy.test;

public class UnitTest1
{
    private readonly ISnoopyService _snoopyService = new SnoopyService();
    [Fact]
    public void Test1()
    {
        Assert.Equal(15, _snoopyService.Add(1, 2, 3, 4, 5));
    }
}

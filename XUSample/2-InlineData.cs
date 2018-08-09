using Xunit;

namespace XUSample.Tests
{
  public class InlineTestData
  {
    [Fact]
    public void Nine()
    {
      var sut = new NumberChecker();

      var result = sut.IsLessThanTen(9);

      Assert.True(result);
    }
    [Fact]
    public void Ten()
    {
      var sut = new NumberChecker();

      var result = sut.IsLessThanTen(10);

      Assert.False(result);
    }

    //InlineData Allows for passing in of multiple parameters
    [Theory]
    [InlineData(9, true)]
    [InlineData(10, false)]
    public void DataDriven(int number, bool expectedResult)
    {
      var sut = new NumberChecker();

      var result = sut.IsLessThanTen(number);

      Assert.Equal(expectedResult, result);
    }
  }
}

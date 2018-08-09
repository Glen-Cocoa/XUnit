using Xunit;

namespace XUSample.Tests
{
  public class ClassDataTestExample
  {
    
    //takes a Type which xUnit uses to obtain the data for tests
    [Theory]
    [ClassData(typeof(NumberCheckerTestData))]
    public void CheckValueLessThanTen(int value, bool expectedResult)
    {
      var numChecker = new NumberChecker();

      var result = numChecker.IsLessThanTen(value);

      Assert.Equal(expectedResult, result);
    }
  }
}

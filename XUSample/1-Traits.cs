using Xunit;

namespace XUSample.Tests
{
  public class Class1
    {
    //Fact replaces Test Attribute
    //Trait takes a key value pair with which to categorize tests
    [Fact]
    [Trait("Category", "PassingTest")]
    public void PassingTest()
    {
      Assert.Equal(4, Add(2, 2));
    }

    //Skip skips the test and returns a custom message
    [Fact(Skip = "CUSTOM MESSAGE GOES HERE")]
    //[Fact]
    [Trait("Category", "FailingTest")]
    public void FailingTest()
    {
      Assert.Equal(5, Add(2, 2));
    }

    //InlindeData allows passing in of multiple values to the same test
    //Fact becomes Theory for any test with multiple possible results

    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    //[InlineData(6)]
    public void Theory(int value)
    {
      Assert.True(IsOdd(value));
    }





    public bool IsOdd(int value)
    {
      return value % 2 == 1;
    }

    public int Add(int a, int b)
    {
      return a + b;
    }
  }
}

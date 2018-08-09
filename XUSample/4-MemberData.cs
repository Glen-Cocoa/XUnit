using System.Collections.Generic;
using Xunit;

namespace XUSample.Tests
{
  public class MemberDataTestExample
  {
    //MemberData attribute can be used to fetch data for a [Theory] from a static property or method of a Type

    //to load data from an enumerable property on the test class
    [Theory]
    [MemberData(nameof(Data))]
    public void LessThanTenMemberDataProperty(int value, bool expectedResult)
    {
      var numChecker = new NumberChecker();

      var result = numChecker.IsLessThanTen(value);

      Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> Data =>
      new List<object[]>
      {
        new object[] {9, true},
        new object[] {10, false}
      };

    //xunit has documentation for how to pass data into a theory in many different ways
    // https://github.com/xunit/xunit/blob/master/src/xunit.core/TheoryData.cs
  }
}

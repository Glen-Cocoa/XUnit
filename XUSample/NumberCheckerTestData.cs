using System.Collections;
using System.Collections.Generic;

namespace XUSample.Tests
{
  public class NumberCheckerTestData : IEnumerable<object[]>
  {
    public IEnumerator<object[]> GetEnumerator()
    {
      yield return new object[] { 9, true };
      yield return new object[] { 10, false };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }
}

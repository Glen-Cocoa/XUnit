using System;
using Xunit;

namespace XUSample.Tests
{
  public class SetupAndTeardown : IDisposable
  {

    public SetupAndTeardown()
    {
      //per-test setup code goes here
    }

    [Fact]
    public void Test1()
    {
      Assert.True(true);
    }
    [Fact]
    public void Test2()
    {
      Assert.True(true);
    }
    [Fact]
    public void Test3()
    {
      Assert.True(true);
    }
    public void Dispose()
    {
      //per-test teardown code goes here
    }
  }
}

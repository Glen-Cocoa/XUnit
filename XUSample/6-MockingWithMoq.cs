using Xunit;
using Moq;

namespace XUSample.Tests
{
  public class MoqTestExample
  {
    [Fact]
    public void MockSomething()
    {
      var mockObject = new Mock<IMockedInterface>();
      var sut = new ClassToMock(mockObject.Object);

      sut.Message("a message");

      mockObject.Verify(x => x.MethodCall("a message"), Times.Once);
    }
  }
}

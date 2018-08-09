namespace XUSample.Tests
{
  public class ClassToMock
  {
    private readonly IMockedInterface _target;

    public ClassToMock(IMockedInterface target)
    {
      _target = target;
    }

    public void Message(string message)
    {
      _target.MethodCall(message);
    }
  }
}

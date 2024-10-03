namespace ConsoleApp1;

public class Test
{
    private readonly IEnumerable<ILogger> _loggers;
    public Test(IEnumerable<ILogger> loggers)
    {
        _loggers = loggers;
    }

    public void Log()
    {
        foreach (var loger in _loggers)
        {
            loger.Log();
        }
    }
  
}
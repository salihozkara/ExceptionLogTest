using System;
using Microsoft.Extensions.Logging;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Logging;

namespace LogTest;

public class SampleAppService : ApplicationService
{
    public void DoSomething()
    {
        throw new MyException("This is a user friendly exception.");
    }
}

public class MyException : Exception, IHasLogLevel, IUserFriendlyException
{
    public LogLevel LogLevel { get; set; } = LogLevel.Warning;

    public MyException(string message) : base(message)
    {
    }
}

public class MyException2 : Exception, IExceptionWithSelfLogging
{
    public MyException2(string message) : base(message)
    {
    }
    public void Log(ILogger logger)
    {
        logger.LogWarning("This is a user friendly exception.");
    }
}
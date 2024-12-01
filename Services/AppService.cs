public class AppService : IAppService
{

    private readonly ILogger<AppService> _logger;

    public AppService(ILogger<AppService> logger)
    {
        _logger = logger;
    }

    public string GetStringApp()
    {
        _logger.LogInformation("Getting string from AppService");
        return "Hello World!";
    }
}

public interface IAppService
{
    string GetStringApp();
}
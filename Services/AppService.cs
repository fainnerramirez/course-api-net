public class AppService : IAppService
{
    public string GetStringApp()
    {
        return "Hello World!";
    }
}

public interface IAppService
{
    string GetStringApp();
}
public class TimeMiddleware 
{
    private readonly RequestDelegate next;

    public TimeMiddleware(RequestDelegate nextRequest)
    {
        next  = nextRequest;
    }

    public async Task Invoke(Microsoft.AspNetCore.Http.HttpContext context){
        await next(context);

        var exist = context.Request.Query.Any(e => e.Key == "time");

        if(exist){
            await context.Response.WriteAsync(DateTime.Now.ToShortTimeString());
        }
    }    
}

public static class TimeMiddlewareExtension
{
    public static IApplicationBuilder UseTimeMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<TimeMiddleware>();
    }
}
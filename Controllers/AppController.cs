using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/api/[controller]")]
public class AppController : ControllerBase
{
    private readonly IAppService _appService;
    public AppController(IAppService appService)
    {
        _appService = appService;
    }

    public IActionResult Get(){
        var result = _appService.GetStringApp();
        return Ok(result);
    }
}
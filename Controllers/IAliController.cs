using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AliServiceController : ControllerBase
{
    private readonly IAliService _AliService;
    public AliServiceController(IAliService AliService)
    {
        _AliService = AliService;  
    }
    [HttpGet]
    [Route("OddMonths")]
    public ActionResult <List<string>> oddMonths()
    {
    List<string> oddMonth = _AliService.GetOddMonths();
        return Ok(oddMonth);
    }
     
}
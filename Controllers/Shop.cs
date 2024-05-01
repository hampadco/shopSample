

using Microsoft.AspNetCore.Mvc;

[Route("[Action]")]
[ApiController]
public class Shop : Controller
{
    [HttpGet]

    public string  Index()
    {
        return "Hello from Shop Controller";
    }
    
}
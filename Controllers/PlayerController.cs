using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bulkybook.Models;

namespace bulkybook.Controllers;

public class PlayerController : Controller 
{
        public const string SessionToken = "_Token";
    private readonly IConfiguration Configuration;
    private readonly ILogger<PlayerController> _logger;
    public PlayerController(IConfiguration configuration,ILogger<PlayerController> logger){
        Configuration = configuration;
        _logger = logger;
    }

    public IActionResult Index()
    {

            var seshToken = HttpContext.Session.GetString(SessionToken);
            ViewData["token"] = seshToken;
            ViewData["LayoutName"] = "_Layout";
            _logger.LogInformation("Session Token in player conroller{SeshToken}",seshToken);
            
            return View();
    }
    
}
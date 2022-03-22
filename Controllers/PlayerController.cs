using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bulkybook.Data;
using bulkybook.Models;

namespace bulkybook.Controllers;

public class PlayerController : Controller 
{
   
    private IPlayerRepository _playerRepository;
        public const string SessionToken = "_Token";
    private readonly IConfiguration Configuration;
    private readonly ILogger<PlayerController> _logger;
    public PlayerController(IConfiguration configuration,ILogger<PlayerController> logger,IPlayerRepository playerRepository){
        Configuration = configuration;
        _logger = logger;
        _playerRepository = playerRepository;
    }

    public IActionResult Index()
    {
        Config conf = new Config();
        Player player = new Player();
        conf.clientID = int.Parse(Configuration["clientID"]);
        conf.apiKey = Guid.Parse(Configuration["apiKey"].ToString());
        conf.rootUrl = Configuration["rootUrl"].ToString();
        conf.memType = "3";
            var seshToken = HttpContext.Session.GetString(SessionToken);
            ViewData["token"] = seshToken;
            ViewData["LayoutName"] = "_Layout";
            _logger.LogInformation("Session Token in player conroller{SeshToken}",seshToken);
            var playerRes = _playerRepository.GetById(conf.clientID);
            ViewData["res"] = playerRes;
            return View();
    }
    
}
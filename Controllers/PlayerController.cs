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

    public async Task<IActionResult> Index(string token)
    {
        Config conf = new Config();
        Player player = new Player();
        conf.clientID = int.Parse(Configuration["clientID"]);
        conf.apiKey = Guid.Parse(Configuration["apiKey"].ToString());
        conf.rootUrl = Configuration["rootUrl"].ToString();
        conf.memType = "3";
            var seshToken = HttpContext.Session.GetString(SessionToken);
            ViewData["token"] = token;
            ViewData["LayoutName"] = "_Layout";
            _logger.LogInformation("Session Token in player conroller{SeshToken}",seshToken);
            var playerRes = _playerRepository.GetById(conf.clientID);
            OAuthResponse authd = await _playerRepository.AuthorizeUser(token);
            ViewData["res"] = playerRes.Result;
            ViewData["athd"] = authd.membership_id;
            return await Task.Run(() => View());
    }
}
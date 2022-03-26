using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bulkybook.Models;
using bulkybook.Data;

namespace bulkybook.Controllers;

public class HomeController : Controller
{
    private IPlayerRepository _playerRepository;
    public const string SessionToken = "_Token";
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _configuration;
    private static readonly HttpClient client = new HttpClient();

    public HomeController(ILogger<HomeController> logger,IConfiguration configuration,IPlayerRepository playerRepository)
    {
        _logger = logger;
        _configuration = configuration;
        _playerRepository = playerRepository;
    }
    public IActionResult Authorize()
    {
Config conf = new Config();
//add logic to handle if session is set
        conf.clientID = int.Parse(_configuration["clientID"]);
        conf.apiKey = Guid.Parse(_configuration["apiKey"].ToString());
        conf.rootUrl = _configuration["rootUrl"].ToString();
        conf.memType = "3"; 
        try
        {
            // set if  block to catch session data and test if its valid.g
            string requestBody =$"https://www.bungie.net/en/oauth/authorize?client_id={conf.clientID}&response_type=code";
            RedirectResult redirectResult = new RedirectResult(requestBody,false);
            return redirectResult;
        }
        catch(Exception e){
             TempData["error"] = e.Message;
            return View();
        }
    }
    
    public async Task<IActionResult> Loggedin(string code){
        //conditional rendering so non logged in users get redirected to login/home page

        if(code == null || code.Length == 0){
            //redirect to home/login
            ViewData["LayoutName"] = "_LayoutLogin";
            return RedirectToAction("Index","Home");
        }else{
            //set sessiontoken and make request to get user info
            // populate appropriate memories with player info
            //persistence needed?

            if(string.IsNullOrEmpty(HttpContext.Session.GetString(SessionToken))){
            HttpContext.Session.SetString(SessionToken,code);
            var seshToken = HttpContext.Session.GetString(SessionToken);
            ViewData["LayoutName"] = "_Layout";
            _logger.LogInformation("Session Token: {SeshToken}",seshToken);
            ViewData["token"]= seshToken;
            var authToken = await _playerRepository.AuthorizeUser(seshToken);
            ViewData["autht"] = authToken;
            return await Task.Run(() => View("Player",  authToken));
            }else{
                return await Task.Run(() => View("Index"));
            }
           
        }
    }
    public IActionResult Index(string code)
    {
        Config conf = new Config();
        conf.clientID = int.Parse(_configuration["clientID"]);
        conf.apiKey = Guid.Parse(_configuration["apiKey"].ToString());
        conf.rootUrl = _configuration["rootUrl"].ToString();
        conf.memType = "3";

        if(!string.IsNullOrEmpty(HttpContext.Session.GetString(SessionToken))){
        {
            try
            {
                ViewData["LayoutName"] = "_Layout";
                //var view =  await Authorize(conf.clientID.ToString());
                return View();
            }
            catch(Exception e){
                TempData["error"] = e.Message;
                return View();
            }
        }
        }else{
            ViewData["LayoutName"] = "_LayoutLogin";
            return View();
        }
    }
     public  IActionResult Player()
    {
        Config conf = new Config();
        Player player = new Player();
        conf.clientID = int.Parse(_configuration["clientID"]);
        conf.apiKey = Guid.Parse(_configuration["apiKey"].ToString());
        conf.rootUrl = _configuration["rootUrl"].ToString();
        conf.memType = "3";
            var seshToken = HttpContext.Session.GetString(SessionToken);
            ViewData["token"] = seshToken;
            ViewData["LayoutName"] = "_Layout";
            _logger.LogInformation("Session Token in player conroller{SeshToken}",seshToken);
            var playerRes = _playerRepository.GetById("B89jdVf9V/lAhQot2WFMlaCa+5XptA7aCAAA");
           // OAuthResponse authd =  _playerRepository.AuthorizeUser(seshToken);
            ViewData["res"] = playerRes.Result;
            //ViewData["athd"] = authd.membership_id;
            return View();
    }
  
    private static async Task<string> CallBungieNetUser(string apiKey, string rootUrl,string clientID)
    {  
        try{
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("x-api-key",$"{apiKey}");
           string responseBody = await client.GetStringAsync(rootUrl+$"/User/GetBungieNetUserById/{clientID}/");
           return responseBody;
        }
        catch(HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message: {0} ",e.Message);
            return e.Message;
        }
        
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
//System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1+AsyncStateMachineBox`1[bulkybook.Models.OAuthResponse,bulkybook.Data.PlayerRepository+<AuthorizeUser>d__4] 
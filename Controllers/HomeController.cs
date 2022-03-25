using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bulkybook.Models;


namespace bulkybook.Controllers;

public class HomeController : Controller
{
    public const string SessionToken = "_Token";
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration Configuration;
    private static readonly HttpClient client = new HttpClient();

    public HomeController(ILogger<HomeController> logger,IConfiguration configuration)
    {
        _logger = logger;
        Configuration = configuration;
    }
    public IActionResult Authorize()
    {
Config conf = new Config();
//add logic to handle if session is set
        conf.clientID = int.Parse(Configuration["clientID"]);
        conf.apiKey = Guid.Parse(Configuration["apiKey"].ToString());
        conf.rootUrl = Configuration["rootUrl"].ToString();
        conf.memType = "3"; 
        try
        {
            // set if  block to catch session data and test if its valid.g
            string requestBody =$"https://www.bungie.net/en/OAuth/Authorize?client_id={conf.clientID}&response_type=code";
            RedirectResult redirectResult = new RedirectResult(requestBody,false);
            return redirectResult;
        }
        catch(Exception e){
             TempData["error"] = e.Message;
            return View();
        }
    }
    
    public IActionResult Loggedin(string code){
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
            RouteValueDictionary dict = new RouteValueDictionary();
            dict.Add("token",seshToken);
            return RedirectToAction("Index","Player",dict);
            }else{
                return RedirectToAction("Index","Home");
            }
           
        }
    }
    public IActionResult Index()
    {
        Config conf = new Config();
        conf.clientID = int.Parse(Configuration["clientID"]);
        conf.apiKey = Guid.Parse(Configuration["apiKey"].ToString());
        conf.rootUrl = Configuration["rootUrl"].ToString();
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

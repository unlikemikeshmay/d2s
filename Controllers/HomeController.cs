using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bulkybook.Models;
using System.Threading.Tasks;

namespace bulkybook.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration Configuration;
    private static readonly HttpClient client = new HttpClient();

    public HomeController(ILogger<HomeController> logger,IConfiguration configuration)
    {
        _logger = logger;
        Configuration = configuration;
    }
    public async Task<IActionResult> Authorize(string clientID)
    {
Config conf = new Config();
//add logic to handle if session is set
     /*    conf.clientID = int.Parse(Configuration["clientID"]);
        conf.apiKey = Guid.Parse(Configuration["apiKey"].ToString());
        conf.rootUrl = Configuration["rootUrl"].ToString();
        conf.memType = "3"; */
        try
        {
            // set if  block to catch session data and test if its valid.

            string requestBody =$"https://www.bungie.net/en/OAuth/Authorize?&response_type=code";
            RedirectResult redirectResult = new RedirectResult(requestBody,false);
            return redirectResult;
        }
        catch(Exception e){
             TempData["error"] = e.Message;
            return View();
        }
    }
    public async Task<IActionResult> Index()
    {
        Config conf = new Config();
        conf.clientID = int.Parse(Configuration["clientID"]);
        conf.apiKey = Guid.Parse(Configuration["apiKey"].ToString());
        conf.rootUrl = Configuration["rootUrl"].ToString();
        conf.memType = "3";

        try
        {
            //var view =  await Authorize(conf.clientID.ToString());
             
            return View();
        }
        catch(Exception e){
             TempData["error"] = e.Message;
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

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

    
    public async Task<IActionResult> Index()
    {

        Config conf = new Config();
        conf.clientID = int.Parse(Configuration["clientID"]);
        conf.apiKey = Guid.Parse(Configuration["apiKey"].ToString());
        conf.rootUrl = Configuration["rootUrl"].ToString();
        conf.memType = "3";
        try
        {
            string res = await CallBungieNetUser(conf.apiKey.ToString(),conf.rootUrl,conf.clientID.ToString());
            return View(res); 
        }
        catch(Exception e){
            return View(e.Message);
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

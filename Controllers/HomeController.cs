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

    
    public async IActionResult Index()
    {

        Config conf = new Config();
        conf.clientID = int.Parse(Configuration["clientID"]);
        conf.apiKey = Guid.Parse(Configuration["apiKey"].ToString());
        conf.rootUrl = Configuration["rootUrl"].ToString();
        conf.memType = "3";

        await CallBungieNet();

        return View(conf); 
    }
    private static async Task CallBungieNet(string apiKey)
    {  
       
        client.DefaultRequestHeaders.Accept.Clear();
         client.DefaultRequestHeaders.Add("x-api-key",$"{apiKey}");
         client.GetStringAsync
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

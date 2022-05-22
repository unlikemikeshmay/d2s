using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bulkybook.Models;
using bulkybook.Data;
using System.Text.Json;
using System.Net;


namespace bulkybook.Controllers;

public class HomeController : Controller
{
    
   
    string bearer;
    Player player = new Player();
    PlayerViewModel pvm = new PlayerViewModel();
    OAuthResponse authToken = new OAuthResponse();
    private IPlayerRepository _playerRepository;
    public const string SessionToken = "_Token";
    public const string pvmData = "_pvm";
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
        conf.apiKey = _configuration["apiKey"];
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
            if(!string.IsNullOrEmpty(HttpContext.Session.GetString(SessionToken))){
                //check if the token is expired--
            }
           

            // populate appropriate memories with player info
            //persistence needed? 
            ViewData["LayoutName"] = "_Layout";
            _logger.LogInformation("Session Token: {SeshToken}",code);
           // ViewData["token"] = code;
            authToken = await _playerRepository.AuthorizeUser(code);

            var key = "bearer";
            var membership_id_key = "membership_id";
            var value = authToken.access_token;

            //setting bearer token and membership_id to cookies for later retrieval.

            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTime.Now.AddSeconds(Convert.ToDouble(authToken.expires_in));
            Response.Cookies.Append(key,value,cookieOptions);
            Response.Cookies.Append(membership_id_key,authToken.membership_id);
            Console.WriteLine("cookie from request {0}",Request.Cookies["bearer"]);
            //CHECK WHY ID DOESNT ACTUALLY EQUAL ID. RUN DEBUG AGAIN BESIDE LIVE
            if(authToken.access_token != null){
                player = await _playerRepository.GetById(authToken.membership_id,authToken.access_token);

            }
            if(authToken.access_token != null && player.uniqueName != null){
               ViewData["authmem"] = authToken.access_token;
                ViewData["disp"] = player.uniqueName;
                

            }
            else{
                ViewData["disp"] = "access token is null or steamdisplay is null";
                ViewData["player"] = player.uniqueName;
            }
/*             pvm.Player = player;
            pvm.OAuthResponse = authToken; */
            if(player.membershipId > 0)
            {      

            return await Task.Run(() => RedirectToAction("Player",authToken));
            }
            else {
                return await Task.Run(() => View("Player"));
            }  
        }
    }
    public IActionResult Index(string code)
    {
        Config conf = new Config();
        conf.clientID = int.Parse(_configuration["clientID"]);
        conf.apiKey = _configuration["apiKey"];
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
     public  async Task<IActionResult> Player(OAuthResponse oAuthResponse)
    {

        Config conf = new Config();
        
        conf.clientID = int.Parse(_configuration["clientID"]);
        conf.apiKey = _configuration["apiKey"];
        conf.rootUrl = _configuration["rootUrl"].ToString();
        conf.memType = "3";
        string key = "bearer";
        var membership_id_key = "membership_id";
        string bearer = Request.Cookies[key];
        string membership_id = Request.Cookies[membership_id_key];
       
            _logger.LogInformation("Session Token in player conroller{SeshToken}",bearer);
            ViewData["LayoutName"] = "_Layout";

            try{
                
                Console.WriteLine("bearer: {0}",bearer);
                GetUserMembershipData getUserMembershipData = new GetUserMembershipData();
                GetProfileResponse profile = new GetProfileResponse();
                getUserMembershipData = await _playerRepository.GetMembershipDataById(Convert.ToInt64(membership_id),Convert.ToInt32(conf.memType),bearer);

                profile = await _playerRepository.GetProfile(Convert.ToInt64(getUserMembershipData.Response.destinyMemberships[0].membershipId),3,bearer);
                Console.WriteLine("profile");

                var enumerator = profile.Response.characters.data.GetEnumerator();
                enumerator.MoveNext();
                do{
                    Console.WriteLine(enumerator.Current.Key);
                    var enum2 = enumerator.Current.Value.stats.GetEnumerator();
                    enum2.MoveNext();
                    do{
                        enum2.MoveNext();
                        Console.WriteLine(enum2.Current.Value);
                        enum2.MoveNext();
                    }while(enum2.MoveNext());

                }while(enumerator.MoveNext());
                pvm.destinyProfileResponse = profile.Response;
                string pvmJson = JsonSerializer.Serialize(pvm);

                //why is this here? <<<<******>>>>>>>
                HttpContext.Session.SetString(pvmData,pvmJson);
                return await Task.Run(() => View("Player",pvm));
            }catch(Exception e)
            {
                Debug.WriteLine("Exception Message: "+ e.Message);
                return await Task.Run(() => View("Player"));
            }
            
    }
    public async Task<IActionResult> ViewCharacter(Int32 id)
    {
        
        return await Task.Run(() => View("Character"));
    }
    public async Task<IActionResult> CharacterList()
    {
        try{
            var pvm = JsonSerializer.Deserialize<PlayerViewModel>(HttpContext.Session.GetString(pvmData));
            ViewData["characters"] = pvm.destinyProfileResponse.characters.data.Values;
            return await Task.Run(() => PartialView("_charactersPartial"));
        }catch(Exception e)
        {
            Console.WriteLine("Error in partial view: {0}",e.Message);
            return await Task.Run(() => PartialView("_charactersPartial"));
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
//System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1+AsyncStateMachineBox`1[bulkybook.Models.OAuthResponse,bulkybook.Data.PlayerRepository+<AuthorizeUser>d__4] 
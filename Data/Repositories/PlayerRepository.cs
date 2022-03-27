using bulkybook.Models;
using Flurl;
using Flurl.Http;

namespace bulkybook.Data
{
    public class PlayerRepository : IPlayerRepository
    {
         
        private IConfiguration _configuration;
        private readonly HttpClient _httpClient;
         public PlayerRepository(HttpClient httpClient,IConfiguration configuration){
             _configuration = configuration;
             _httpClient = httpClient;
             

         }
        public async Task<Player> GetById(string memid,string bt)
        {
            Config _config = new Config();
             _config.apiKey = Guid.Parse(_configuration["apiKey"].ToString());
             _config.clientID = int.Parse(_configuration["clientID"]);
             _config.rootUrl = _configuration["rootUrl"].ToString();
            Url url = $"{_config.rootUrl}/User/GetBungieNetUserById/{memid}";
            try
            {
            //might have to set bearer token- dunno yet
              Player player = new Player();
              dynamic d = await url.WithHeader("x-api-key",$"{_config.apiKey}").WithHeader("Authorization", $"Bearer {bt}").GetJsonAsync();
                player.membershipId = d.membershipId;
                player.uniqueName = d.uniqueName;
                player.normalizedName = d.normalizedName;
                player.displayName = d.displayName;
                player.profilePicture = d.profilePicture;
                player.profileTheme = d.profileTheme;
                player.userTitle = d.userTitle;
                player.successMessageFlags = d.successMessageFlags;
                player.isDeleted = d.isDeleted;
                player.about = d.about;
                player.firstAccess = d.firstAccess;
                player.lastUpdate = d.lastUpdate;
                player.legacyPortalUID = d.legacyPortalUID;
                //player.context = d.context;
                player.psnDisplayName = d.psnDisplayName;
                player.xboxDisplayName = d.xboxDisplayName;
                player.fbDisplayName = d.fbDisplayName;
                player.showActivity = d.showActivity;
                player.locale = d.locale;
                player.localeInheritDefault = d.localeInheritDefault;
                player.lastBanReportId = d.lastBanReportId;
                player.showGroupMessaging = d.showGroupMessaging;
                player.profilePicturePath = d.profilePicturePath;
                player.profilePictureWidePath = d.profilePictureWidePath;
                player.profileThemeName = d.profileThemeName;
                player.userTitleDisplay = d.userTitleDisplay;
                player.statusText = d.statusText;
                player.statusDate = d.statusDate;
                player.profileBanExpire = d.profileBanExpire;
                player.blizzardDisplayName = d.blizzardDisplayName;
                player.steamDisplayName = d.steamDisplayName;
                player.stadiaDisplayName = d.stadiaDisplayName;
                player.twitchDisplayName = d.twitchDisplayName;
                player.cachedBungieGlobalDisplayName = d.cachedBungieGlobalDisplayName;
                player.cachedBungieGlobalDisplayNameCode = d.cachedBungieGlobalDisplayNameCode;
              Console.WriteLine("Player returned from the response: {0}",player);
                return player;  
            }catch(HttpRequestException e){

                Console.WriteLine(
                    "\nException Caught!");
                Console.WriteLine("Message :{0} ",e.Message);
                Player player = new Player();
                player.steamDisplayName = e.Message;
                return player;
            }
        }
         public async Task<OAuthResponse> AuthorizeUser(string id)
        {
             Config _config = new Config();
             _config.apiKey = Guid.Parse(_configuration["apiKey"].ToString());
             _config.clientID = int.Parse(_configuration["clientID"]);
             _config.rootUrl = _configuration["rootUrl"].ToString();
             _config.secret = _configuration["secret"];
            try{

            
                var url = new Uri($"https://www.bungie.net/Platform/App/OAuth/Token/");
/*                 var res  = await url.WithHeaders(new { Content = "application/x-www-form-urlencoded",Authorization = $"Basic {_config.clientID}:{_config.secret}"}).PostUrlEncodedAsync(new {
                    client_id = _config.clientID,
                    grant_type = "authorization_code",
                    code = id,
                }).ReceiveJson(); */
                dynamic d  = await url.PostUrlEncodedAsync(new {
                    grant_type = "authorization_code",
                    client_id = _config.clientID,
                    code = id,
                }).ReceiveJson();
                Console.WriteLine("response after authorize post: {0}",d);

                OAuthResponse response = new OAuthResponse();
                response.access_token = d.access_token;
                response.token_type = d.token_type;
                response.expires_in = d.expires_in;
                response.membership_id = d.membership_id;
                //response.membership_id = res;
            return response;
            }catch(FlurlHttpException e){
                OAuthResponse res = new OAuthResponse();
                res.membership_id = e.Message;
                
                res.token_type = e.StackTrace;
                res.access_token  = e.Source;
                
                return res;
            }
            
            

        }
    }
}
// "client_id={CLIENT_ID}&grant_type=authorization_code&code={authCode}"
//?code=5f830898adfee9ff0648507cf022a8ac
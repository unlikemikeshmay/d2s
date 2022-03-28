using bulkybook.Models;
using RestSharp;
using RestSharp.Authenticators;

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
            try
            {
            //might have to set bearer token- dunno yet
            
              Player player = new Player();
              var client = new RestClient($"https://www.bungie.net/Platform/User/GetBungieNetUserById/{memid}");
                var request = new RestRequest();
                request.AddHeader("X-API-Key", $"{_config.apiKey}");
                request.AddHeader("Authorization", $"Bearer {bt}");
                //request.AddHeader("Cookie", "Q6dA7j3mn3WPBQVV6Vru5CbQXv0q+I9ddZfGro+PognXQwjWM8PS+VE_=v1StlRgw__FbC; __cflb=0H28vP5GxS7vgVH4MZT6rB7QcDNQ8jpmSJi6XkaDAcT; bungleanon=sv=BAAAAABwKwAAAAAAAAb7OAAAAAAAAAAAAAAAAAAHZ3Lq4AzaCEAAAACQg46DxdP2yYl6zi9Z94CQjKinNiyhSXsDchGidR7XXhY14t5PWUT3xv+GLR5WggwiP3B2AJgH6dEK7hjvY2Qx&cl=MC4xMTEyMC4zNzM0Mjc4; bungled=3028881891976556922; bungledid=B1keE+HDgvNGoFOJZca+gFEHZ3Lq4AzaCAAA");

                RestResponse response = await client.ExecuteAsync(request);

                Console.WriteLine(response.Content);
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

                var client = new RestClient($"{_config.rootUrl}/App/OAuth/Token/");
                var request = new RestRequest();
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                //request.AddHeader("Cookie", "Q6dA7j3mn3WPBQVV6Vru5CbQXv0q+I9ddZfGro+PognXQwjWM8PS+VE_=v1tNlRgw__HGw; __cflb=04dToX7HjFoF4QAzoaHehFaMj5fkjPR1wypgjcLnPd; bungleanon=sv=BAAAAABwKwAAAAAAAAb7OAAAAAAAAAAAAAAAAAAHZ3Lq4AzaCEAAAACQg46DxdP2yYl6zi9Z94CQjKinNiyhSXsDchGidR7XXhY14t5PWUT3xv+GLR5WggwiP3B2AJgH6dEK7hjvY2Qx&cl=MC4xMTEyMC4zNzM0Mjc4; bungled=3028881891976556922; bungledid=B1keE+HDgvNGoFOJZca+gFEHZ3Lq4AzaCAAA");
                request.AddParameter("grant_type", "authorization_code");
                request.AddParameter("code", $"{id}");
                request.AddParameter("client_id", $"{_config.clientID}");
                var response = await client.PostAsync<OAuthResponse>(request);
                Console.WriteLine(response);
                
                Console.WriteLine("response after authorize post: {0}",request);
                OAuthResponse oAuthResponse = new OAuthResponse();
                if (response.access_token != null){
                    oAuthResponse.access_token = response.access_token;
                oAuthResponse.token_type = response.token_type;
                oAuthResponse.expires_in = response.expires_in;
                oAuthResponse.membership_id = response.membership_id; 
                }
                
                
                //response.membership_id = res;
            return oAuthResponse;
            
            
            

        }
    }
}
// "client_id={CLIENT_ID}&grant_type=authorization_code&code={authCode}"
//?code=5f830898adfee9ff0648507cf022a8ac


/* var client = new RestClient("https://www.bungie.net/Platform/User/GetBungieNetUserById/20814900");
client.Timeout = -1;
var request = new RestRequest(Method.GET);
request.AddHeader("X-API-Key", "7973756ba5f149d0860c8f815440e8f4");
request.AddHeader("Authorization", "BearerCJWBBBKGAgAgPRqKv6IQtL3I/XLYPcB4LnQBW8O9K37ByTzVn+mHHv3gAAAATdW5N1e//0Exh6xlowP/cV7thAxxXy+3fCuw/mXhAdQ9FOrw7UqvKiZBj7a/K0/o/nau43nuTPdAWHIsB7Gzeqq3lrVtmJ6oIBpQOJUxEjaFuDmQLQzASldcYBXDFzvnBB1eGybsZ7R4lrGLCz3UXw0dhT7/d1j8muUENz4a33TswVRrBf5G2/I3XOIEKkyAmTUeVbtiWVbVufsrHQme8a29lNa/74MzmLsO0zecPN2dFTBmV1tNgKiiUh2SvIUbh+O93g9q+r/pz2LPWeHvlVMyJyAesVCT0KyqkwCLrqE=");
request.AddHeader("Cookie", "Q6dA7j3mn3WPBQVV6Vru5CbQXv0q+I9ddZfGro+PognXQwjWM8PS+VE_=v1StlRgw__FbC; __cflb=0H28vP5GxS7vgVH4MZT6rB7QcDNQ8jpmSJi6XkaDAcT; bungleanon=sv=BAAAAABwKwAAAAAAAAb7OAAAAAAAAAAAAAAAAAAHZ3Lq4AzaCEAAAACQg46DxdP2yYl6zi9Z94CQjKinNiyhSXsDchGidR7XXhY14t5PWUT3xv+GLR5WggwiP3B2AJgH6dEK7hjvY2Qx&cl=MC4xMTEyMC4zNzM0Mjc4; bungled=3028881891976556922; bungledid=B1keE+HDgvNGoFOJZca+gFEHZ3Lq4AzaCAAA");
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content); */
using bulkybook.Models;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

using RestSharp.Serializers.NewtonsoftJson;

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
             _config.apiKey = _configuration["apiKey"];
             _config.clientID = int.Parse(_configuration["clientID"]);
             _config.rootUrl = _configuration["rootUrl"].ToString();
            try
            {
            //might have to set bearer token- dunno yet
            
              Player player = new Player();
              var client = new RestClient($"https://www.bungie.net/Platform/User/GetBungieNetUserById/{memid}");

                var request = new RestRequest();
                request.AddHeader("X-API-Key", "7973756ba5f149d0860c8f815440e8f4");
                request.AddHeader("Authorization", $"Bearer{bt}");
              //  request.AddHeader("Cookie", "Q6dA7j3mn3WPBQVV6Vru5CbQXv0q+I9ddZfGro+PognXQwjWM8PS+VE_=v1o9hRgw__bwh; __cflb=04dToX7HjFoF4QAzoaHehFaMj5fkjPQrk9YXqJMpwM; bungleanon=sv=BAAAAABwKwAAAAAAAAb7OAAAAAAAAAAAAAAAAAAHZ3Lq4AzaCEAAAACQg46DxdP2yYl6zi9Z94CQjKinNiyhSXsDchGidR7XXhY14t5PWUT3xv+GLR5WggwiP3B2AJgH6dEK7hjvY2Qx&cl=MC4xMTEyMC4zNzM0Mjc4; bungled=3028881891976556922; bungledid=B1keE+HDgvNGoFOJZca+gFEHZ3Lq4AzaCAAA");
                var response = await client.ExecuteGetAsync(request);
                dynamic resdes = JsonConvert.DeserializeObject(response.Content);
                var res = resdes.Response;
                Console.WriteLine("inside getbyid");
                Console.WriteLine(response.Content);
                if(response.Content == null){
                    player.displayName= "res is null";
                    return player;
                }
                player.membershipId = Convert.ToInt64(res.membershipId);
                player.uniqueName = res.uniqueName;
                player.normalizedName = res.normalizedName;
                //player.displayName = res.displayName;
                player.displayName = res.displayName;
                player.profilePicture = Convert.ToInt32(res.profilePicture);
                player.profileTheme = Convert.ToInt32(res.profileTheme);
                player.userTitle = Convert.ToInt32(res.userTitle);
                player.successMessageFlags = Convert.ToInt64(res.successMessageFlags);
                player.isDeleted = Convert.ToBoolean(res.isDeleted);
                player.about = res.about;
                player.firstAccess = Convert.ToDateTime(res.firstAccess);
                player.lastUpdate = Convert.ToDateTime(res.lastUpdate);
                player.legacyPortalUID = Convert.ToInt64(res.legacyPortalUID);
                //player.context = d.context;
                player.psnDisplayName = res.psnDisplayName;
                player.xboxDisplayName = res.xboxDisplayName;
                player.fbDisplayName = res.fbDisplayName;
                player.showActivity = Convert.ToBoolean(res.showActivity);
                player.locale = res.locale;
                player.localeInheritDefault = Convert.ToBoolean(res.localeInheritDefault);
                player.lastBanReportId = Convert.ToInt64(res.lastBanReportId);
                player.showGroupMessaging = Convert.ToBoolean(res.showGroupMessaging);
                player.profilePicturePath = res.profilePicturePath;
                player.profilePictureWidePath = res.profilePictureWidePath;
                player.profileThemeName = res.profileThemeName;
                player.userTitleDisplay = res.userTitleDisplay;
                player.statusText = res.statusText;
                player.statusDate = Convert.ToDateTime(res.statusDate);
                player.profileBanExpire = Convert.ToDateTime(res.profileBanExpire);
                player.blizzardDisplayName = res.blizzardDisplayName;
                player.steamDisplayName = res.steamDisplayName;
                player.stadiaDisplayName = res.stadiaDisplayName;
                player.twitchDisplayName = res.twitchDisplayName;
                player.cachedBungieGlobalDisplayName = res.cachedBungieGlobalDisplayName;
                player.cachedBungieGlobalDisplayNameCode = Convert.ToInt16(res.cachedBungieGlobalDisplayNameCode); 
              Console.WriteLine("Player returned from the response: {0}",player);
                return player;  
            }catch(HttpRequestException e){

                Console.WriteLine(
                    "\nException Caught!");
                Console.WriteLine("Message :{0} ",e.Message);
                Console.WriteLine(e.StatusCode);
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.StackTrace);
                Player player = new Player();
                player.steamDisplayName = e.Message;
                return player;
            }
        }
         public async Task<OAuthResponse> AuthorizeUser(string id)
        {
             Config _config = new Config();
             _config.apiKey = _configuration["apiKey"];
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
                var response = await client.ExecutePostAsync(request);
                dynamic res = JsonConvert.DeserializeObject(response.Content);
                Console.WriteLine(res);
                
                Console.WriteLine("response after authorize post: {0}",request);
                OAuthResponse oAuthResponse = new OAuthResponse();
                if (res.access_token != null){
                oAuthResponse.access_token = res.access_token;
                oAuthResponse.token_type = res.token_type;
                oAuthResponse.expires_in = res.expires_in;
                oAuthResponse.membership_id = res.membership_id; 
                }
                
                
                //response.membership_id = res;
            return oAuthResponse;
            
            
            

        }
        public async Task<GetProfileResponse> GetProfile(Int64 destinyMembershipId, Int32 membershipType,string bearer)
        {
           GetProfileResponse profileResponse = new GetProfileResponse();

            Config _config = new Config();
             _config.apiKey = _configuration["apiKey"];
             _config.clientID = int.Parse(_configuration["clientID"]);
             _config.rootUrl = _configuration["rootUrl"].ToString();
             _config.secret = _configuration["secret"];
            string endpointUrl = $"/Destiny2/{membershipType}/Profile/{destinyMembershipId}/?components=200,102,100,201,205";
            string completeUrl = $"{_config.rootUrl}{endpointUrl}";
           // Console.WriteLine("Complete url: {0}",completeUrl);
             Player player = new Player();
              var client = new RestClient(completeUrl);

                var request = new RestRequest();
                request.AddHeader("X-API-Key", _config.apiKey.ToString());
                request.AddHeader("Authorization", $"Bearer{bearer}");
              //  request.AddHeader("Cookie", "Q6dA7j3mn3WPBQVV6Vru5CbQXv0q+I9ddZfGro+PognXQwjWM8PS+VE_=v1o9hRgw__bwh; __cflb=04dToX7HjFoF4QAzoaHehFaMj5fkjPQrk9YXqJMpwM; bungleanon=sv=BAAAAABwKwAAAAAAAAb7OAAAAAAAAAAAAAAAAAAHZ3Lq4AzaCEAAAACQg46DxdP2yYl6zi9Z94CQjKinNiyhSXsDchGidR7XXhY14t5PWUT3xv+GLR5WggwiP3B2AJgH6dEK7hjvY2Qx&cl=MC4xMTEyMC4zNzM0Mjc4; bungled=3028881891976556922; bungledid=B1keE+HDgvNGoFOJZca+gFEHZ3Lq4AzaCAAA");
                var response = await client.ExecuteGetAsync(request);
                var resdes = JsonConvert.DeserializeObject<GetProfileResponse>(response.Content);
                Console.WriteLine("getprofileresponse: {0}",resdes.Response);
                return resdes;
        }
        public async Task<VendorResponse> GetVendorList(long characterId, long destinyMembershipId, int membershipType)
        {
            VendorResponse vendorResponse = new VendorResponse();
            return vendorResponse;
        }

        public async Task<GetUserMembershipData> GetMembershipDataById(long membershipId, int membershipType,string bearer)
        {   GetUserMembershipData getUserMembershipData = new GetUserMembershipData();
             Config _config = new Config();
             _config.apiKey = _configuration["apiKey"];
             _config.clientID = int.Parse(_configuration["clientID"]);
             _config.rootUrl = _configuration["rootUrl"].ToString();
             _config.secret = _configuration["secret"];
            string endpointUrl = $"/User/GetMembershipsById/{membershipId}/{membershipType}/";
            string completeUrl = $"{_config.rootUrl}{endpointUrl}";
            var client = new RestClient(completeUrl);
             var request = new RestRequest();
                request.AddHeader("X-API-Key", _config.apiKey);
                request.AddHeader("Authorization", $"Bearer{bearer}");
                var response = await client.ExecuteGetAsync(request);
                var resdes = JsonConvert.DeserializeObject<GetUserMembershipData>(response.Content);
                Console.WriteLine("membership details: {0}",resdes.Response);
                
                return resdes;
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
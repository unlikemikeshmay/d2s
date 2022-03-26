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
        public async Task<string> GetById(string id)
        {
            Config _config = new Config();
             _config.apiKey = Guid.Parse(_configuration["apiKey"].ToString());
             _config.clientID = int.Parse(_configuration["clientID"]);
             _config.rootUrl = _configuration["rootUrl"].ToString();
            string combinedUrl = $"{_config.rootUrl}/User/GetBungieNetUserById/?id={id}/";
            try
            {
                _httpClient.DefaultRequestHeaders.Add("x-api-key",_config.apiKey.ToString());
                 //_httpClient.DefaultRequestHeaders.Add("Content-Type","application/x-www-form-urlencoded");
                HttpResponseMessage response = await _httpClient.GetAsync(combinedUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;  
            }catch(HttpRequestException e){
                Console.WriteLine(
                    "\nException Caught!");
                Console.WriteLine("Message :{0} ",e.Message);
                return e.Message;
            }
        }
       /*  public Task<OAuthResponse> AuthorizeUser(string id)
        {
             Config _config = new Config();
             _config.apiKey = Guid.Parse(_configuration["apiKey"].ToString());
             _config.clientID = int.Parse(_configuration["clientID"]);
             _config.rootUrl = _configuration["rootUrl"].ToString();
             _config.secret = _configuration["secret"];

                var x = $"{_config.clientID}:{_config.secret}";
                var y = System.Text.Encoding.UTF8.GetBytes(x);
                var encoded = System.Convert.ToBase64String(y);


            //_httpClient.DefaultRequestHeaders.Add("Content-Type","application/x-www-form-urlencoded");
            _httpClient.DefaultRequestHeaders.Add("X-API-Key",$"{_config.apiKey}");
            //_httpClient.DefaultRequestHeaders.Add("Authorization",$"Basic {x}");

            OAuthResponse oauthresponse = new OAuthResponse();

            //convert authorization to base64
        //string url = $"https://www.bungie.net/Platform/App/OAuth/Token/?grant_type=authorization_code&client_id={_config.clientID}&code={id}";
           
            
            

            var dict = new Dictionary<string,string>();
            dict.Add("grant_type","authorization_code");
            dict.Add("code",$"id");
            dict.Add("client_id",_config.clientID.ToString());
            //dict.Add("redirect_uri","https://destinyscan.azurewebsites.net/home/loggedin/{code}");
            

            
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post,url){Content = new FormUrlEncodedContent(dict)};
            
            
            HttpResponseMessage response =  _httpClient.Send(request);
            //var res = response.Content.ReadAsStringAsync();
            oauthresponse.membership_id =  response.ToString();
            return oauthresponse;
        } */
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
                var res  = await url.PostUrlEncodedAsync(new {
                    grant_type = "authorization_code",
                    client_id = _config.clientID,
                    code = id,
                }).ReceiveJson();
                Console.WriteLine("response after authorize post: {0}",res);
                OAuthResponse response = res;
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
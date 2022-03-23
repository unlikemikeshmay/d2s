using bulkybook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;

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
        public async Task<string> GetById(int id)
        {
            Config _config = new Config();
             _config.apiKey = Guid.Parse(_configuration["apiKey"].ToString());
             _config.clientID = int.Parse(_configuration["clientID"]);
             _config.rootUrl = _configuration["rootUrl"].ToString();
            string combinedUrl = $"{_config.rootUrl}/User/GetBungieNetUserById/?id={_config.clientID}/";
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

        public async Task<OAuthResponse> AuthorizeUser(string id)
        {
             Config _config = new Config();
             _config.apiKey = Guid.Parse(_configuration["apiKey"].ToString());
             _config.clientID = int.Parse(_configuration["clientID"]);
             _config.rootUrl = _configuration["rootUrl"].ToString();

                var x = $"{_config.clientID}:{_config.apiKey}";
                var y = System.Text.Encoding.UTF8.GetBytes(x);
                var encoded = System.Convert.ToBase64String(y);


            //_httpClient.DefaultRequestHeaders.Add("Content-Type","application/x-www-form-urlencoded");
            _httpClient.DefaultRequestHeaders.Add("X-API-Key",$"{_config.apiKey}");
            _httpClient.DefaultRequestHeaders.Add("Authorization",$"Basic {encoded}");

            OAuthResponse oauthresponse = new OAuthResponse();

            //convert authorization to base64

            string url = $"https://www.bungie.net/Platform/App/OAuth/Token/?grant_type=authorization_code&client_id={_config.clientID}&code={id}";
            
            var urlEncoded = HttpUtility.UrlEncode(url);

            var dict = new Dictionary<string,string>();
            dict.Add("grant_type","authorization_code");
            dict.Add("client_id",_config.clientID.ToString());
            dict.Add("code",$"id");

            
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post,url){Content = new FormUrlEncodedContent(dict)};
            
            
            HttpResponseMessage response = await _httpClient.SendAsync(request);
            var res =  await response.Content.ReadAsStringAsync();
            oauthresponse.membership_id =  res.ToString();
            return oauthresponse;



            /* request.post({
    url: 'https://www.bungie.net/Platform/App/OAuth/Token/',
    headers: {
      'Content-Type': 'application/x-www-form-urlencoded',
      'Authorization': 'Basic ' + X
    }, 
    data: {
      'grant_type': 'authorization_code',
      'code': '7f39897b4a1b17e4f5753a0a90c21***'
    }
  }, function(err, res, body){
    console.log(body);
}); */
        }
    }
}
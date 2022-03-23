using bulkybook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

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
            OAuthResponse oauthresponse = new OAuthResponse();
            string url = "https://www.bungie.net/platform/app/oauth/token/";
            var dict = new Dictionary<string,string>();
            dict.Add("grant_type",$"authorization_code&code={id}");
            dict.Add("client_id",_config.clientID.ToString());
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
            
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post,url){Content = new FormUrlEncodedContent(dict)};
            
            HttpResponseMessage response = await _httpClient.SendAsync(request);
            var res =  await response.Content.ReadAsStringAsync();
            oauthresponse.membership_id =  res.ToString();
            return oauthresponse;
        }
    }
}
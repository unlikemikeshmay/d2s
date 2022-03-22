using bulkybook.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace bulkybook.Data
{
    public class PlayerRepository : IPlayerRepository
    {
        private IConfiguration _configuration;
        static readonly HttpClient client = new HttpClient();
         public PlayerRepository(IHttpClientFactory httpClientFactory,IConfiguration configuration){
             _configuration = configuration;
         }
        public async Player GetById(int id)
        {
            Config config = new Config();
            Player player = new Player();
            config.apiKey = Guid.Parse(_configuration["apiKey"].ToString());
            config.clientID = int.Parse(_configuration["clientID"]);
            config.rootUrl = _configuration["rootUrl"].ToString();
            string combinedUrl = $"{config.rootUrl}//User/GetBungieNetUserById/{config.clientID}/";
            try{
return player;
            }catch(HttpRequestException e){
                Console.WriteLine("\nException Caught!");
                Console.WriteLine();
                
            }

        }
    }
}
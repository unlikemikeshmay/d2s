using System.Collections.Generic;
using bulkybook.Models;

namespace bulkybook.Data
{
    public interface IPlayerRepository
    {
         Task<Player> GetById(string id);
         Task<OAuthResponse> AuthorizeUser(string id);
    }
}

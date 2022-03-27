using System.Collections.Generic;
using bulkybook.Models;

namespace bulkybook.Data
{
    public interface IPlayerRepository
    {
         Task<Player> GetById(string memid,string bt);
         Task<OAuthResponse> AuthorizeUser(string id);
    }
}

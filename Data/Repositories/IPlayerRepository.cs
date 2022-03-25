using System.Collections.Generic;
using bulkybook.Models;

namespace bulkybook.Data
{
    public interface IPlayerRepository
    {
         Task<string> GetById(string id);
         Task<OAuthResponse> AuthorizeUser(string id);
    }
}

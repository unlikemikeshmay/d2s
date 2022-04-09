using System.Collections.Generic;
using bulkybook.Models;

namespace bulkybook.Data
{
    public interface IPlayerRepository
    {
         Task<Player> GetById(string memid,string bt);
         Task<OAuthResponse> AuthorizeUser(string id);
         Task<VendorResponse> GetVendorList(Int64 characterId, Int64 destinyMembershipId,Int32 membershipType);
         Task<DestinyProfileResponse> GetProfile(Int64 destinyMembershipId, Int32 membershipType,string bearer);
    }
}
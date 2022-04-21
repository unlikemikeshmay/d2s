using System.Text.Json.Serialization;

namespace bulkybook.Models;

public class UserMembershipData
{
    [JsonPropertyName("destinyMemberships")]
    public List<GroupUserInfoCard> destinyMemberships {get;set;}
    [JsonPropertyName("primaryMembershipId")]
    public Int64 primaryMembershipId {get;set;}
    [JsonPropertyName("bungieNetUser")]
    public GeneralUser bungieNetUser {get;set;}
}
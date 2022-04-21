using System.Text.Json.Serialization;

namespace bulkybook.Models;

public class GroupUserInfoCard

{
    [JsonPropertyName("LastSeenDisplayName")]
    public string LastSeenDisplayName {get;set;}
    [JsonPropertyName("LastSeenDisplayNameType")]
    public Int32 LastSeenDisplayNameType {get;set;}
    [JsonPropertyName("supplementalDisplayName")]
    public string supplementalDisplayName {get;set;}
    [JsonPropertyName("iconPath")]
    public string iconPath {get;set;}

    [JsonPropertyName("crossSaveOverride")]
    public Int32 crossSaveOverride {get;set;}
    [JsonPropertyName("applicableMembershipTypes")]
    public List<Int32> applicableMembershipTypes {get;set;}
    [JsonPropertyName("isPublic")]
    public Boolean isPublic {get;set;}
    [JsonPropertyName("membershipType")]
    public Int32 membershipType {get;set;}
    [JsonPropertyName("membershipId")]
    public Int64 membershipId {get;set;}
    [JsonPropertyName("displayName")]
    public string displayName {get;set;}

    [JsonPropertyName("bungieGlobalDisplayName")]
    public string bungieGlobalDisplayName {get;set;}
    
    [JsonPropertyName("bungieGlobalDisplayNameCode")]
    public Int16 bungieGlobalDisplayNameCode {get;set;}
}
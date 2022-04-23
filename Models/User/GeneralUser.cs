using System.Text.Json.Serialization;

namespace bulkybook.Models;

public class GeneralUser
{
    [JsonPropertyName("membershipId")]
    public Int64 membershipId {get;set;}
    [JsonPropertyName("uniqueName")]
    public string uniqueName {get;set;}
    [JsonPropertyName("normalizedName")]
    public string normalizedName {get;set;}
    [JsonPropertyName("displayName")]
    public string displayName {get;set;}
    [JsonPropertyName("profilePicture")]
    public Int32 profilePicture {get;set;}
    [JsonPropertyName("profileTheme")]
    public Int32 profileTheme {get;set;}
    [JsonPropertyName("userTitle")]
    public Int32 userTitle {get;set;}
    [JsonPropertyName("successMessageFlags")]
    public Int64 successMessageFlags {get;set;}
    [JsonPropertyName("isDeleted")]
    public Boolean isDeleted {get;set;}
    [JsonPropertyName("about")]
    public string about {get;set;}
    [JsonPropertyName("firstAccess")]
    public DateTime firstAccess {get;set;}
    [JsonPropertyName("lastUpdate")]
    public DateTime lastUpdate {get;set;}
    [JsonPropertyName("legacyPortalUID")]
    public Int64 legacyPortalUID {get;set;}
    [JsonPropertyName("context")]
    public UserToUserContext context {get;set;}
    [JsonPropertyName("psnDisplayName")]
    public string psnDisplayName {get;set;}
    [JsonPropertyName("xboxDisplayName")]
    public string xboxDisplayName {get;set;}
    [JsonPropertyName("fbDisplayName")]
    public string fbDisplayName {get;set;}
    [JsonPropertyName("showActivity")]
    public Boolean showActivity {get;set;}
    [JsonPropertyName("locale")]
    public string locale {get;set;}
    [JsonPropertyName("localeInheritDefault")]
    public Boolean localeInheritDefault {get;set;}
    [JsonPropertyName("lastBanReportId")]
    public Int64 lastBanReportId {get;set;}
    [JsonPropertyName("showGroupMessaging")]
    public Boolean showGroupMessaging {get;set;}
    [JsonPropertyName("profilePicturePath")]
    public string profilePicturePath {get;set;}
    [JsonPropertyName("profilePictureWidePath")]
    public string profilePictureWidePath {get;set;}
    [JsonPropertyName("profileThemeName")]
    public string profileThemeName {get;set;}
    [JsonPropertyName("userTitleDisplay")]
    public string userTitleDisplay {get;set;}
    [JsonPropertyName("statusText")]
    public string statusText {get;set;}
    [JsonPropertyName("statusDate")]
    public DateTime statusDate {get;set;}
    [JsonPropertyName("profileBanExpire")]
    public DateTime profileBanExpire {get;set;}
    [JsonPropertyName("blizzardDisplayName")]
    public string blizzardDisplayName {get;set;}
    [JsonPropertyName("steamDisplayName")]
    public string steamDisplayName {get;set;}
    [JsonPropertyName("stadiaDisplayName")]
    public string stadiaDisplayName {get;set;}
    [JsonPropertyName("twitchDisplayName")]
    public string twitchDisplayName {get;set;}
    [JsonPropertyName("cachedBungieGlobalDisplayName")]
    public string cachedBungieGlobalDisplayName {get;set;}
    [JsonPropertyName("cachedBungieGlobalDisplayNameCode")]
    public Int16 cachedBungieGlobalDisplayNameCode {get;set;}

}
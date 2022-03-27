
using System.ComponentModel.DataAnnotations;

public class Player {
    [Key]
    public Int64 membershipId {get;set;}
    public string? uniqueName {get;set;}
    public string? normalizedName {get;set;}
    public string? displayName {get;set;}
    public Int32? profilePicture {get;set;}
    public Int32 profileTheme {get;set;}
    public Int32 userTitle {get;set;}
    public Int64 successMessageFlag {get;set;}
    public Boolean isDeleted {get;set;}
    public string about {get;set;}
    public DateTime firstAccess {get;set;}
    public DateTime lastUpdate {get;set;}
    public Int64 lagacyPortalIUID {get;set;}
    public string? context {get;set;}
    public string? psnDisplayName {get;set;}
    public string? xboxDisplayName {get;set;}
    public string? fbDisplayName {get;set;}
    public Boolean showActivity {get;set;}
    public string? locale {get;set;}
    public Boolean localeInheritDefault {get;set;}
    public Int64 lastBanReportId {get;set;}
    public Boolean showGroupMessaging {get;set;}
    public string? profilePicturePath {get;set;}
    public string? profilePictureWidePath {get;set;}
    public string? profileThemeName {get;set;}
    public string? userTitleDisplay {get;set;}
    public string? statusText {get;set;}
    public DateTime statusDate {get;set;}
    public DateTime profileBanExpire {get;set;}
    public string? blizzardDisplayName {get;set;}
    public string? steamDisplayName {get;set;}
    public string? stadiaDisplayName {get;set;}
    public string? twitchDisplayName {get;set;}
    public string? cachedBungieGlobalDisplayName {get;set;}
    public Int16 cachedBungieGlobalDisplayNameCode {get;set;}
}
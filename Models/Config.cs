using System;
namespace bulkybook.Models;

public enum MembershipType 
{
    None = 0,
    TigerXbox = 1,
    TigerPsn = 2,
    TigerSteam = 3,
    TigerBlizzard = 4,
    TigerStadia = 5,
    TigerDemon = 10,
    BungieNext = 254,
    All = -1
}
public class Config
{
    public int clientID {get;set;}
    public string apiKey {get;set;}
    public string? rootUrl {get;set;}

    public string? memType {get;set;}

    public string? secret {get;set;}
}




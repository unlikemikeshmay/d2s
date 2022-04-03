namespace bulkybook.Models;

public class DestinyProfileComponent
{
    public UserInfoCard userInfo {get;set;}
    public DateTime dateLastPlayed {get;set;}
    public Int32 versionsOwned {get;set;}
    public List<Int64> characterIds {get;set;}
    public List<UInt32> seasonHashes {get;set;}
    public UInt32 currentSeasonHash {get;set;}
    public Int32 currentSeasonRewardPowerCap {get;set;}

}
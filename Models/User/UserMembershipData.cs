namespace bulkybook.Models;

public class UserMembershipData
{
    public List<GroupUserInfoCard> destinyMemberships {get;set;}
    public Int64 primaryMembershipId {get;set;}
    public GeneralUser bungieNetUser {get;set;}
}
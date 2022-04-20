namespace bulkybook.Models;

public class GroupUserInfoCard

{
    public string LastSeenDisplayName {get;set;}
    public Int32 LastSeenDisplayNameType {get;set;}
    public string supplementalDisplayName {get;set;}
    public string iconPath {get;set;}
    public Int32 crossSaveOverride {get;set;}
    public List<Int32> applicableMembershipTypes {get;set;}
    public Boolean isPublic {get;set;}
    public Int32 membershipType {get;set;}
    public Int64 membershipId {get;set;}
    public string displayName {get;set;}
    public string bungieGlobalDisplayName {get;set;}
    public Int16 bungieGlobalDisplayNameCode {get;set;}
}
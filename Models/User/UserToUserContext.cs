namespace bulkybook.Models;

public class UserToUserContext
{
    public Boolean isFollowing {get;set;}
    public IgnoreResponse ignoreStatus {get;set;}
    public DateTime globalIgnoreEndDate {get;set;}
}
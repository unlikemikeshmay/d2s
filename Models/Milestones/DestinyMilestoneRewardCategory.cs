namespace bulkybook.Models;

public class DestinyMilestoneRewardCategory
{
    public UInt32 rewardCategoryHash {get;set;}
    public List<DestinyMilestoneRewardEntry> entries {get;set;}
}
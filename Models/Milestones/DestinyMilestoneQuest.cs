namespace bulkybook.Models;

public class DestinyMilestoneQuest
{
    /*  Quests are defined as Items in content. As such, this is the hash identifier of the DestinyInventoryItemDefinition that represents this quest. It will have pointers to all of the steps in the quest, and display information for the quest (title, description, icon etc) Individual steps will be referred to in the Quest item's DestinyInventoryItemDefinition.setData property, and themselves are Items with their own renderable data.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    public UInt32 questItemHash {get;set;}
    public DestinyQuestStatus status {get;set;}
    public DestinyMilestoneActivity activity {get;set;}
    public List<DestinyChallengeStatus> challenges {get;set;}
    

}
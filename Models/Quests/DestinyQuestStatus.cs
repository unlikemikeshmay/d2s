namespace bulkybook.Models;

public class DestinyQuestStatus
{
    /* he hash identifier for the Quest Item. (Note: Quests are defined as Items, and thus you would use this to look up the quest's DestinyInventoryItemDefinition). For information on all steps in the quest, you can then examine its DestinyInventoryItemDefinition.setData property for Quest Steps (which are *also* items). You can use the Item Definition to display human readable data about the overall quest.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    public UInt32 questHash {get;set;}
    public UInt32 stepHash {get;set;}
    public List<DestinyObjectiveProgress> stepObjectives {get;set;}
    public Boolean tracked {get;set;}
    public Int64 itemInstanceId {get;set;}
    public Boolean completed {get;set;}
    public Boolean redeemed {get;set;}
    public Boolean started {get;set;}
    public UInt32 vendorHash {get;set;}
}
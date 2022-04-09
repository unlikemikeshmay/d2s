namespace bulkybook.Models;

public class DestinyVendorInteractionDefinition
{
    public Int32 interactionIndex {get;set;}
    public List<DestinyVendorInteractionReplyDefinition> replies {get;set;}
    public Int32 vendorCategoryIndex {get;set;}
    /*  If this interaction dialog is about a quest, this is the questline related to the interaction. You can use this to show the quest overview, or even the character's status with the quest if you use it to find the character's current Quest Step by checking their inventory against this questlineItemHash's DestinyInventoryItemDefinition.setData.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    public UInt32 questlineItemHash {get;set;}
    public List<DestinyVendorInteractionSackEntryDefinition> sackInteractionList {get;set;}
    public UInt32 uiInteractionType {get;set;}
    public Int32 interactionType {get;set;}
    public string rewardBlockLabel {get;set;}
    public Int32 rewardVendorCategoryIndex {get;set;}
    public string flavorLineOne {get;set;}
    public string flavorLineTwo {get;set;}
    public DestinyDisplayPropertiesDefinition headerDisplayProperties {get;set;} 
    public string instructions {get;set;}
}
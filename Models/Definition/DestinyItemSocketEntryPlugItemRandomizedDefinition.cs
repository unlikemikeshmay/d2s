namespace bulkybook.Models;

public class DestinyItemSocketEntryPlugItemRandomizedDefinition
{
    public DestinyPlugItemCraftingRequirements craftingRequirements {get;set;}
    public Boolean currentlyCanRoll {get;set;}
    /*  The hash identifier of a DestinyInventoryItemDefinition representing the plug that can be inserted.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    public UInt32 plugItemHash {get;set;}

}
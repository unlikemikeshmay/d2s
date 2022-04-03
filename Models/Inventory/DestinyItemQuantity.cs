namespace bulkybook.Models;

public class DestinyItemQuantity
{
    // Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition 
    public UInt32 itemHash {get;set;}
    public Int64 itemInstanceId {get;set;}
    public Int32 quantity {get;set;}
    public Boolean hasConditionalVisibility {get;set;}
    
}
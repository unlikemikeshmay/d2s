namespace bulkybook.Models;

public class DestinyItemSetBlockEntryDefinition
{
   public Int32 trackingValue {get;set;}
   /*  This is the hash identifier for a DestinyInventoryItemDefinition representing this quest step.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
   public UInt32 itemHash {get;set;}

}
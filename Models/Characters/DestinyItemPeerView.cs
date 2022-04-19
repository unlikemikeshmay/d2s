namespace bulkybook.Models;

public class DestinyItemPeerView
{
    /*  The hash identifier of the item in question. Use it to look up the DestinyInventoryItemDefinition of the item for static rendering data.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    public UInt32 itemHash {get;set;}
    public List<DyeReference> dyes {get;set;}

}
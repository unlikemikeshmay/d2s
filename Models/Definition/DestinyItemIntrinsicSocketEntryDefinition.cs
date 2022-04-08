namespace bulkybook.Models;

public class DestinyItemIntrinsicSocketEntryDefinition
{
    /*  Indicates the plug that is intrinsically inserted into this socket.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    public UInt32 plugItemHash {get;set;}
    public UInt32 socketTypeHash {get;set;}
    /*  Indicates the type of this intrinsic socket.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Sockets.DestinySocketTypeDefinition  */
    public Boolean defaultVisible {get;set;}
    

}
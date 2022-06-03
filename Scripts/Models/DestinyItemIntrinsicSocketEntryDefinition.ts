
export interface DestinyItemIntrinsicSocketEntryDefinition
{
       /*  Indicates the plug that is intrinsically inserted into this socket.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
plugItemHash: number;
socketTypeHash: number;
/*  Indicates the type of this intrinsic socket.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Sockets.DestinySocketTypeDefinition  */
defaultVisible: boolean;
}
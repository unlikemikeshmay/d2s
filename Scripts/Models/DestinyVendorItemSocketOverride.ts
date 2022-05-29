
export interface DestinyVendorItemSocketOverride
{
       /* 
If this is populated, the socket will be overridden with a specific plug.

If this isn't populated, it's being overridden by something more complicated that is only known by the Game Server and God, which means we can't tell you in advance what it'll be.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
singleItemHash:number;
randomizedOptionsCount:number;
/*  This appears to be used to select which socket ultimately gets the override defined here.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Sockets.DestinySocketTypeDefinition  */
socketTypeHash:number;
}
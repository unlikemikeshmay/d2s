import { DestinyItemSocketEntryPlugItemDefinition } from "./DestinyItemSocketEntryPlugItemDefinition";
export interface DestinyItemSocketEntryDefinition
{
      /*  All sockets have a type, and this is the hash identifier for this particular type. Use it to look up the DestinySocketTypeDefinition: read there for more information on how socket types affect the behavior of the socket.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Sockets.DestinySocketTypeDefinition  */
socketTypeHash: number;
/*  If a valid hash, this is the hash identifier for the DestinyInventoryItemDefinition representing the Plug that will be initially inserted into the item on item creation. Otherwise, this Socket will either start without a plug inserted, or will have one randomly inserted.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
singleInitialItemHash: number;
reusable: Array<DestinyItemSocketEntryPlugItemDefinition>;
preventInitializationOnVendorPurchase: boolean;
hidePerksInItemTooltip: boolean;
plugSources: number;
reusablePlugHash: number;
}
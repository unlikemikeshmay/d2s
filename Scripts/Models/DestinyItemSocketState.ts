
export interface DestinyItemSocketState
{
        /* 
The currently active plug, if any.

Note that, because all plugs are statically defined, its effect on stats and perks can be statically determined using the plug item's definition. The stats and perks can be taken at face value on the plug item as the stats and perks it will provide to the user/item.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
plugHash: number;
isEnabled: boolean;
isVisible: boolean;
enableFailIndexes: Array<number>;
}
import { DestinyPlugItemCraftingRequirements } from "./DestinyPlugItemCraftingRequirements";
export interface DestinyItemSocketEntryPlugItemRandomizedDefinition
{
    craftingRequirements: DestinyPlugItemCraftingRequirements;
    currentlyCanRoll: boolean;
    /*  The hash identifier of a DestinyInventoryItemDefinition representing the plug that can be inserted.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    plugItemHash: number;
}
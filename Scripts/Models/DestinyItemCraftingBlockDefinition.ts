import { DestinyItemCraftingBlockBonusPlugDefinition } from "./DestinyItemCraftingBlockBonusPlugDefinition";
export interface DestinyItemCraftingBlockDefinition
{
    outputItemHash: number;
    /*  Mapped to Manifest Database Definition: Destiny.Definitions.Sockets.DestinySocketTypeDefinition  */
    requiredSocketTypeHashes: Array<number>;
    failedRequirementStrings: Array<string>;
    /*  A reference to the base material requirements for crafting with this recipe.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyMaterialRequirementSetDefinition  */
    baseMaterialRequirements: number;
    bonusPlugs: Array<DestinyItemCraftingBlockBonusPlugDefinition> 
}
import { DestinyPlugItemCraftingUnlockRequirement } from "./DestinyPlugItemCraftingUnlockRequirement";
export interface DestinyPlugItemCraftingRequirements
{
    unlockRequirements: Array<DestinyPlugItemCraftingUnlockRequirement> 
    materialRequirementHashes: Array<number>;
}
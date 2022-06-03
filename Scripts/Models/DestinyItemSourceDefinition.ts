import { DestinyInventoryItemStatDefinition } from "./DestinyInventoryItemStatDefinition";
export interface DestinyItemSourceDefinition
{
    level: number;
    minQuality: number;
    maxQuality: number;
    minLevelRequired: number;
    computedStats: Map<number,DestinyInventoryItemStatDefinition>
    sourceHashes: Array<number>;
}
import { DestinyArtifactTierItem } from "./DestinyArtifactTierItem";
export interface DestinyArtifactTier
{
    tierHash: number;
    isUnlocked: boolean;
    pointsToUnlock: number;
    items: Array<DestinyArtifactTierItem>;
}
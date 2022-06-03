import { DestinyArtifactTier } from "./DestinyArtifactTier";
export interface DestinyArtifactCharacterScoped
{
    artifactHash: number;
    pointsUsed: number;
    resetCount: number;
    tiers: Array<DestinyArtifactTier>;
}
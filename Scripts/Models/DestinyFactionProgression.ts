import { DestinyProgressionResetEntry } from "./DestinyProgressionResetEntry";
export interface DestinyFactionProgression
{
    factionHash: number;
    factionVendorIndex: number;
    progressionHash: number;
    /*  The hash identifier of the Progression in question. Use it to look up the DestinyProgressionDefinition in static data.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyProgressionDefinition  */
    dailyProgress: number;
    dailyLimit: number;
    weeklyProgress: number;
    weeklyLimit: number;
    currentProgress: number;
    level: number;
    levelCap: number;
    pstepIndex: number;
    progressToNextLevel: number;
    nextLevelAt: number;
    currentResetCount: number;
    seasonResets: Array<DestinyProgressionResetEntry>;
    rewardItemStates: Array<number>;
}
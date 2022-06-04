import { DestinyObjectiveProgress } from "./DestinyObjectiveProgress";
export interface DestinyRecordComponent
{
    state: number;
    objectives: Array<DestinyObjectiveProgress>;
    internalObjectives: Array<DestinyObjectiveProgress>;
    intervalsRedeemedCount: number;
    completedCount: number;y
    rewardVisibilty: Array<boolean>;
}
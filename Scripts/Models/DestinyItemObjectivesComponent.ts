import { DestinyObjectiveProgress } from "./DestinyObjectiveProgress";
export interface DestinyItemObjectivesComponent
{
    objectives: Array<DestinyObjectiveProgress>;
    flavorObjective: DestinyObjectiveProgress;
    dateCompleted: Date;
}
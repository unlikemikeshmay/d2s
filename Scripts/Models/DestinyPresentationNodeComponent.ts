import { DestinyObjectiveProgress } from "./DestinyObjectiveProgress";
export interface DestinyPresentationNodeComponent
{
    state:number;
    objective: DestinyObjectiveProgress;
    progressValue: number;
    completionValue: number;
    recordCategoryScore: number;
}
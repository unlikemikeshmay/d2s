import { DestinyMilestoneActivityPhase } from "./DestinyMilestoneActivityPhase";
export interface DestinyMilestoneActivityCompletionStatus
{
    completed: boolean;
    phases: Array<DestinyMilestoneActivityPhase>;
}
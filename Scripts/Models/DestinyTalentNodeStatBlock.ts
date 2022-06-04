import { DestinyStat } from "./DestinyStat";
export interface DestinyTalentNodeStatBlock
{
    currentStepStats: Array<DestinyStat>;
     nextStepStats: Array<DestinyStat>;
}
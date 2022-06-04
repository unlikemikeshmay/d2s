import { DestinyMaterialRequirement } from "./DestinyMaterialRequirement";
import { DestinyTalentNodeStatBlock } from "./DestinyTalentNodeStatBlock";
export interface DestinyTalentNode
{
    nodeIndex: number;
    nodeHash: number;
    state: number;
    stepIndex: number;
    materialsToUpgrade: Array<DestinyMaterialRequirement>;
    activationGridLevel: number;
    progressPercent: number;
    hidden: boolean;
    nodeStatsBlock: DestinyTalentNodeStatBlock;
}
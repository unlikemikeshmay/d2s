import { DestinyMilestoneRewardEntry } from "./DestinyMilestoneRewardEntry";
export interface DestinyMilestoneRewardCategory
{
    rewardCategoryHash: number;
    entries: Array<DestinyMilestoneRewardEntry>;
}
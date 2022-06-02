import { DestinyObjectiveProgress } from "./DestinyObjectiveProgress";
export interface DestinyQuestStatus
{
        /* he hash identifier for the Quest Item. (Note: Quests are defined as Items, and thus you would use this to look up the quest's DestinyInventoryItemDefinition). For information on all steps in the quest, you can then examine its DestinyInventoryItemDefinition.setData property for Quest Steps (which are *also* items). You can use the Item Definition to display human readable data about the overall quest.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
questHash: number;
stepHash: number;
stepObjectives: Array<DestinyObjectiveProgress>;
tracked: boolean;
itemInstanceId: number;
completed: boolean;
redeemed: boolean;
started: boolean;
vendorHash: number;
}
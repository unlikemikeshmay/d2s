import { DestinyVendorInteractionReplyDefinition } from "./DestinyVendorInteractionReplyDefinition";
import { DestinyVendorInteractionSackEntryDefinition } from "./DestinyVendorInteractionSackEntryDefinition";
import { DestinyDisplayPropertiesDefinition } from "./DestinyDisplayPropertiesDefinition";
export interface DestinyVendorInteractionDefinition
{
    interactionIndex: number;
    replies: Array<DestinyVendorInteractionReplyDefinition>;
    vendorCategoryIndex: number;
    /*  If this interaction dialog is about a quest, this is the questline related to the interaction. You can use this to show the quest overview, or even the character's status with the quest if you use it to find the character's current Quest Step by checking their inventory against this questlineItemHash's DestinyInventoryItemDefinition.setData.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    questlineItemHash: number;
    sackInteractionList: Array<DestinyVendorInteractionSackEntryDefinition>;
    uiInteractionType: number;
    interactionType: number;
    rewardBlockLabel: string;
    rewardVendorCategoryIndex: number;
    flavorLineOne: string;
    flavorLineTwo: string;
    headerDisplayProperties: DestinyDisplayPropertiesDefinition 
    instructions: string;
}
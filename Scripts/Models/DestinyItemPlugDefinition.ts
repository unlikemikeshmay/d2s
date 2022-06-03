import {DestinyPlugRuleDefinition} from './DestinyPlugRuleDefinition';
import { DestinyParentItemOverride } from './DestinyParentItemOverride';
import { DestinyEnergyCapacityEntry } from './DestinyEnergyCapacityEntry';
import { DestinyEnergyCostEntry } from './DestinyEnergyCostEntry';
export interface DestinyItemPlugDefinition
{
    insertionRules: Array<DestinyPlugRuleDefinition>;
    plugCategoryIdentifier: string;
    plugCategoryHash: number;
    onActionRecreateSelf: boolean;
    /*  If inserting this plug requires materials, this is the hash identifier for looking up the DestinyMaterialRequirementSetDefinition for those requirements.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyMaterialRequirementSetDefinition  */
    insertionMaterialRequirementHash: number;
    /*  In the game, if you're inspecting a plug item directly, this will be the item shown with the plug attached. Look up the DestinyInventoryItemDefinition for this hash for the item.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    previewItemOverrideHash: number;
    /*  It's not enough for the plug to be inserted. It has to be enabled as well. For it to be enabled, it may require materials. This is the hash identifier for the DestinyMaterialRequirementSetDefinition for those requirements, if there is one.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyMaterialRequirementSetDefinition  */
    enabledMaterialRequirementHash: number;
    enabledRules: Array<DestinyPlugRuleDefinition>;
    uiPlugLabel: string;
    plugStyle: number;
    plugAvailability: number;
    alternateUiPlugLabel: string;
    alternatePlugStyle: number;
    isDummyPlug: boolean;
    parentItemOverride: DestinyParentItemOverride;
    energyCapacity: DestinyEnergyCapacityEntry;
    energyCost: DestinyEnergyCostEntry;
}
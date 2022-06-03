import { DestinyItemVersionDefinition } from "./DestinyItemVersionDefinition";
export interface DestinyItemQualityBlockDefinition
{
    itemLevels: Array<number>;
    qualityLevel: number;
    infusionCategoryName: string;
    infusionCategoryHash: number;
    infusionCategoryHashes: Array<number>;
    /*  An item can refer to pre-set level requirements. They are defined in DestinyProgressionLevelRequirementDefinition, and you can use this hash to find the appropriate definition.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Progression.DestinyProgressionLevelRequirementDefinition  */
    progressionLevelRequirementHash: number;
    currentVersion: number;
    versions: Array<DestinyItemVersionDefinition>;
    
}
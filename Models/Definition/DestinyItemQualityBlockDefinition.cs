namespace bulkybook.Models;

public class DestinyItemQualityBlockDefinition
{
    public List<Int32> itemLevels {get;set;}
    public Int32 qualityLevel {get;set;}
    public string infusionCategoryName {get;set;}
    public UInt32 infusionCategoryHash {get;set;}
    public List<UInt32> infusionCategoryHashes {get;set;}
    /*  An item can refer to pre-set level requirements. They are defined in DestinyProgressionLevelRequirementDefinition, and you can use this hash to find the appropriate definition.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Progression.DestinyProgressionLevelRequirementDefinition  */
    public UInt32 progressionLevelRequirementHash {get;set;}
    public UInt32 currentVersion {get;set;}
    public List<DestinyItemVersionDefinition> versions {get;set;}
    

}
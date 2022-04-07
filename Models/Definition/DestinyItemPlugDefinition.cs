namespace bulkybook.Models;

public class DestinyItemPlugDefinition
{
    public List<DestinyPlugRuleDefinition> insertionRules {get;set;}
    public string plugCategoryIdentifier {get;set;}
    public UInt32 plugCategoryHash {get;set;}
    public Boolean onActionRecreateSelf {get;set;}
    /*  If inserting this plug requires materials, this is the hash identifier for looking up the DestinyMaterialRequirementSetDefinition for those requirements.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyMaterialRequirementSetDefinition  */
    public UInt32 insertionMaterialRequirementHash {get;set;}
    /*  In the game, if you're inspecting a plug item directly, this will be the item shown with the plug attached. Look up the DestinyInventoryItemDefinition for this hash for the item.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    public UInt32 previewItemOverrideHash {get;set;}
    /*  It's not enough for the plug to be inserted. It has to be enabled as well. For it to be enabled, it may require materials. This is the hash identifier for the DestinyMaterialRequirementSetDefinition for those requirements, if there is one.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyMaterialRequirementSetDefinition  */
    public UInt32 enabledMaterialRequirementHash {get;set;}
    public List<DestinyPlugRuleDefinition> enabledRules {get;set;}
    public string uiPlugLabel {get;set;}
    public Int32 plugStyle {get;set;}
    public Int32 plugAvailability {get;set;}
    public string alternateUiPlugLabel {get;set;}
    public Int32 alternatePlugStyle {get;set;}
    public Boolean isDummyPlug {get;set;}
    public DestinyParentItemOverride parentItemOverride {get;set;}
    public DestinyEnergyCapacityEntry energyCapacity {get;set;}
    public DestinyEnergyCostEntry energyCost {get;set;}
    

}
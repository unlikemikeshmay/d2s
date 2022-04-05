namespace bulkybook.Models;

public class DestinyItemCraftingBlockDefinition
{
    public UInt32 outputItemHash {get;set;}
    /*  Mapped to Manifest Database Definition: Destiny.Definitions.Sockets.DestinySocketTypeDefinition  */
    public List<UInt32> requiredSocketTypeHashes {get;set;}
    public List<string> failedRequirementStrings {get;set;}
    /*  A reference to the base material requirements for crafting with this recipe.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyMaterialRequirementSetDefinition  */
    public UInt32 baseMaterialRequirements {get;set;}
    public List<DestinyItemCraftingBlockBonusPlugDefinition> bonusPlugs {get;set;}

}
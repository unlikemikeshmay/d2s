namespace bulkybook.Models;

public class DestinyPlugItemCraftingRequirements
{
    public List<DestinyPlugItemCraftingUnlockRequirement> unlockRequirements {get;set;}
    public List<UInt32> materialRequirementHashes {get;set;}

}
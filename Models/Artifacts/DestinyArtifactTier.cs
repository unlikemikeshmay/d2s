namespace bulkybook.Models;

public class DestinyArtifactTier
{
    public UInt32 tierHash {get;set;}
    public Boolean isUnlocked {get;set;}
    public Int32 pointsToUnlock {get;set;}
    public List<DestinyArtifactTierItem> items {get;set;}
}
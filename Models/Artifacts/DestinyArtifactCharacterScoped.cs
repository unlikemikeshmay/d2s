namespace bulkybook.Models;

public class DestinyArtifactCharacterScoped
{
    public UInt32 artifactHash {get;set;}
    public Int32 pointsUsed {get;set;}
    public Int32 resetCount {get;set;}
    public List<DestinyArtifactTier> tiers {get;set;}

}
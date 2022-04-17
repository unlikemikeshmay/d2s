namespace bulkybook.Models;

public class DestinyArtifactProfileScoped
{
    /*  Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Artifacts.DestinyArtifactDefinition  */
    public UInt32 artifactHash {get;set;}
    public DestinyProgression pointProgression {get;set;}
    public Int32 pointsAcquired {get;set;}
    public DestinyProgression powerBonusProgression {get;set;}
    public Int32 powerBonus {get;set;}
}
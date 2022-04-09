namespace bulkybook.Models;

public class DestinyTalentNode
{
    public Int32 nodeIndex {get;set;}
    public UInt32 nodeHash {get;set;}
    public Int32 state {get;set;}
    public Int32 stepIndex {get;set;}
    public List<DestinyMaterialRequirement> materialsToUpgrade {get;set;}
    public Int32 activationGridLevel {get;set;}
    public float progressPercent {get;set;}
    public Boolean hidden {get;set;}
    public DestinyTalentNodeStatBlock nodeStatsBlock {get;set;}

}
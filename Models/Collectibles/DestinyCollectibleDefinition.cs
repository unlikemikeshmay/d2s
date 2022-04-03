namespace bulkybook.Models;

public class DestinyCollectibleDefinition
{
    public DestinyDisplayPropertiesDefinition displayProperties {get;set;}
    public Int32 scope {get;set;}
    public string sourceString {get;set;}
    public UInt32 sourceHash {get;set;}
    //mapped to DestinyInventoryItemDefinition
    public UInt32 itemHash {get;set;}
    public DestinyCollectibleAcquisitionBlock acquisitionInfo {get;set;}

    public DestinyCollectibleStateBlock stateInfo {get;set;}
    public DestinyPresentationChildBlock presentationInfo {get;set;}
    public Int32 presentationNodeType {get;set;}
    public List<string> traitIds {get;set;}
    public List<UInt32> traitHashes {get;set;}
    public List<UInt32> parentNodeHashes {get;set;}
    public UInt32 hash {get;set;}
    public Int32 index {get;set;}
    public Boolean redacted {get;set;}

}
namespace bulkybook.Models;

public class DestinyItemSourceDefinition
{
    public Int32 level {get;set;}
    public Int32 minQuality {get;set;}
    public Int32 maxQuality {get;set;}
    public Int32 minLevelRequired {get;set;}
    public Dictionary<UInt32,DestinyInventoryItemStatDefinition> computedStats {get;set;}
    public List<UInt32> sourceHashes {get;set;}
}
namespace bulkybook.Models;

public class DestinyItemSocketBlockDefinition
{
    public string detail {get;set;}
    public List<DestinyItemSocketEntryDefinition> socketEntries {get;set;}
    public List<DestinyItemIntrinsicSocketEntryDefinition> intrinsicSockets {get;set;}
    public List<DestinyItemSocketCategoryDefinition> socketCategories {get;set;}

}
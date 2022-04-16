namespace bulkybook.Models;

public class DestinyPlugSetDefinition
{
    public DestinyDisplayPropertiesDefinition displayProperties {get;set;}
    public List<DestinyItemSocketEntryPlugItemRandomizedDefinition> reusablePlugItems {get;set;}
    public Boolean isFakePlugSet {get;set;}
    public UInt32 hash {get;set;}
    public Int32 index {get;set;}
    public Boolean redacted {get;set;}
}   
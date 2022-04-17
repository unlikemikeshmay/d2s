namespace bulkybook.Models;

public class DestinyChecklistDefinition
{
    public DestinyDisplayPropertiesDefinition displayProperties {get;set;}
    public string viewActionString {get;set;}
    public Int32 scope {get;set;}
    public List<DestinyChecklistEntryDefinition> entries {get;set;} 
    public UInt32 hash {get;set;}
    public Int32 index {get;set;}
    public Boolean redacted {get;set;}
}
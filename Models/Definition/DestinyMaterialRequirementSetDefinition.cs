namespace bulkybook.Models;

public class DestinyMaterialRequirementSetDefinition
{
    public List<DestinyMaterialRequirement> materials {get;set;}
    public UInt32 hash {get;set;}
    public Int32 index {get;set;}
    public Boolean redacted {get;set;}
}
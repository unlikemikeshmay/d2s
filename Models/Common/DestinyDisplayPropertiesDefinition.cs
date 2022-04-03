namespace bulkybook.Models;

public class DestinyDisplayPropertiesDefinition
{
    public string description {get;set;}
    public string name {get;set;}
    public string icon {get;set;}
    public List<DestinyIconSequenceDefinition> iconSequences {get;set;}
    public string highResIcon {get;set;}
    public Boolean hasIcon {get;set;}
}
namespace bulkybook.Models;

public class DestinyProfileProgressionComponent
{
    public Dictionary<UInt32,DestinyChecklistDefinition> checklists {get;set;}
    public DestinyArtifactProfileScoped seasonalArtifact {get;set;}
}
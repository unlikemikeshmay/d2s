namespace bulkybook.Models;

public class DestinyItemObjectiveBlockDefinition
{
    public List<UInt32> objectiveHashes {get;set;}
    public List<UInt32> displayActivityHashes {get;set;}
    public Boolean requireFullObjectiveCompletion {get;set;}
    /*  The hash for the DestinyInventoryItemDefinition representing the Quest to which this Quest Step belongs.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    public UInt32 questlineItemHash {get;set;}
    public string narrative {get;set;}
    public string objectiveVerbName {get;set;}
    public string questTypeIdentifier {get;set;}
    public UInt32 questTypeHash {get;set;}
    public List<DestinyObjectiveDisplayProperties> perObjectiveDisplayProperties {get;set;}
    public Boolean displayAsStatTracker {get;set;}

}
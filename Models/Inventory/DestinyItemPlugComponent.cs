namespace bulkybook.Models;

public class DestinyItemPlugComponent
{
    public List<DestinyObjectiveProgress> plugObjectives {get;set;}
    /*  The hash identifier of the DestinyInventoryItemDefinition that represents this plug.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    public UInt32 plugItemHash {get;set;}
    public Boolean canInsert {get;set;}
    public Boolean enabled {get;set;}
    public List<Int32> insertFailIndexes {get;set;}
    public List<Int32> enableFailIndexes {get;set;}

}
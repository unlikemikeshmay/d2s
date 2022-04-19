namespace bulkybook.Models;

public class  DestinyProfileTransitoryTrackingEntry
{
    /*  OPTIONAL - If this is tracking a DestinyLocationDefinition, this is the identifier for that location.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyLocationDefinition  */
    public UInt32 locationHash {get;set;}
    /*  OPTIONAL - If this is tracking the status of a DestinyInventoryItemDefinition, this is the identifier for that item.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    public UInt32 itemHash {get;set;}
    /*  OPTIONAL - If this is tracking the status of a DestinyObjectiveDefinition, this is the identifier for that objective.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyObjectiveDefinition  */
    public UInt32 objectiveHash {get;set;}
    /*  OPTIONAL - If this is tracking the status of a DestinyActivityDefinition, this is the identifier for that activity.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyActivityDefinition  */
    public UInt32 activityHash {get;set;}
    /* 
OPTIONAL - If this is tracking the status of a quest, this is the identifier for the DestinyInventoryItemDefinition that containst that questline data.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    public UInt32 questlineItemHash {get;set;}
    public DateTime trackedDate {get;set;}

}
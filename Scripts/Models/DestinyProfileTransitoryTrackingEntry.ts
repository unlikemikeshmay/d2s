
export interface DestinyProfileTransitoryTrackingEntry
{
      /*  OPTIONAL - If this is tracking a DestinyLocationDefinition, this is the identifier for that location.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyLocationDefinition  */
locationHash: number;
/*  OPTIONAL - If this is tracking the status of a DestinyInventoryItemDefinition, this is the identifier for that item.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
itemHash: number;
/*  OPTIONAL - If this is tracking the status of a DestinyObjectiveDefinition, this is the identifier for that objective.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyObjectiveDefinition  */
objectiveHash: number;
/*  OPTIONAL - If this is tracking the status of a DestinyActivityDefinition, this is the identifier for that activity.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyActivityDefinition  */
activityHash: number;
/* 
OPTIONAL - If this is tracking the status of a quest, this is the identifier for the DestinyInventoryItemDefinition that containst that questline data.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
questlineItemHash: number;
trackedDate: Date;
}
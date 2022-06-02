import { ActivityModeType } from "./DestinyMilestoneActivity";
import { DestinyMilestoneActivityCompletionStatus } from "./DestinyMilestoneActivityCompletionStatus";
export interface DestinyMilestoneActivityVariant
{
       /*  The hash for the specific variant of the activity related to this milestone. You can pull more detailed static info from the DestinyActivityDefinition, such as difficulty level.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyActivityDefinition  */
activityHash: number;
completionStatus: DestinyMilestoneActivityCompletionStatus;
/*  The hash identifier of the most specific Activity Mode under which this activity is played. This is useful for situations where the activity in question is - for instance - a PVP map, but it's not clear what mode the PVP map is being played under. If it's a playlist, this will be less specific: but hopefully useful in some way.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyActivityModeDefinition  */
/*  The hash identifier of the most specific Activity Mode under which this activity is played. This is useful for situations where the activity in question is - for instance - a PVP map, but it's not clear what mode the PVP map is being played under. If it's a playlist, this will be less specific: but hopefully useful in some way.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyActivityModeDefinition  */
activityModeHash: number;
activityModeType: ActivityModeType ;
}
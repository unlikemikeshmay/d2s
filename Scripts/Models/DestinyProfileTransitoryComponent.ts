import { DestinyProfileTransitoryPartyMember } from "./DestinyProfileTransitoryPartyMember";
import { DestinyProfileTransitoryCurrentActivity } from "./DestinyProfileTransitoryCurrentActivity";
import { DestinyProfileTransitoryJoinability } from "./DestinyProfileTransitoryJoinability";
import { DestinyProfileTransitoryTrackingEntry } from "./DestinyProfileTransitoryTrackingEntry";
export interface DestinyProfileTransitoryComponent
{
    partyMembers: Array<DestinyProfileTransitoryPartyMember>;
    currentActivity: DestinyProfileTransitoryCurrentActivity;
    joinability: DestinyProfileTransitoryJoinability;
    tracking: Array<DestinyProfileTransitoryTrackingEntry>;
    /*  The hash identifier for the DestinyDestinationDefinition of the last location you were orbiting when in orbit.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyDestinationDefinition  */
    lastOrbitedDestinationHash: number;
}
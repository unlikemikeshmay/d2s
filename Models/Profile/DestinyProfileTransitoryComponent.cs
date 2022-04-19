namespace bulkybook.Models;

public class DestinyProfileTransitoryComponent
{
    public List<DestinyProfileTransitoryPartyMember> partyMembers {get;set;}
    public DestinyProfileTransitoryCurrentActivity currentActivity {get;set;}
    public DestinyProfileTransitoryJoinability joinability {get;set;}
    public List<DestinyProfileTransitoryTrackingEntry> tracking {get;set;}
    /*  The hash identifier for the DestinyDestinationDefinition of the last location you were orbiting when in orbit.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyDestinationDefinition  */
    public UInt32 lastOrbitedDestinationHash {get;set;}
}
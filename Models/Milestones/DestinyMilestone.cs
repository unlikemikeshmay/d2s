namespace bulkybook.Models;

public class DestinyMilestone
{
    /*  The unique identifier for the Milestone. Use it to look up the DestinyMilestoneDefinition, so you can combine the other data in this contract with static definition data.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Milestones.DestinyMilestoneDefinition  */
    public UInt32 milestoneHash {get;set;}
    public List<DestinyMilestoneQuest> availableQuests {get;set;}
    public List<DestinyMilestoneChallengeActivity> activities {get;set;}
    public Dictionary<string,float> values {get;set;}
    /*  A milestone may have one or more active vendors that are "related" to it (that provide rewards, or that are the initiators of the Milestone). I already regret this, even as I'm typing it. [I told you I'd regret this] You see, sometimes a milestone may be directly correlated with a set of vendors that provide varying tiers of rewards. The player may not be able to interact with one or more of those vendors. This will return the hashes of the Vendors that the player *can* interact with, allowing you to show their current inventory as rewards or related items to the Milestone or its activities.

Before we even use it, it's already deprecated! How much of a bummer is that? We need more data.
Type: array
Array Contents: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyVendorDefinition  */
    public List<UInt32> vendorHashes {get;set;}
    public List<DestinyMilestoneVendor> vendors {get;set;}
    public List<DestinyMilestoneRewardCategory> rewards {get;set;}
    public DateTime startDate {get;set;}
    public DateTime endDate {get;set;}
    public Int32 order {get;set;}
    

}
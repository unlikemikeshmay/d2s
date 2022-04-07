namespace bulkybook.Models;

public class DestinyItemStatBlockDefinition
{
    public Boolean disablePrimaryStatDisplay {get;set;}
    /*  If the item's stats are meant to be modified by a DestinyStatGroupDefinition, this will be the identifier for that definition.

If you are using live data or precomputed stats data on the DestinyInventoryItemDefinition.stats.stats property, you don't have to worry about statGroupHash and how it alters stats: the already altered stats are provided to you. But if you want to see how the sausage gets made, or perform computations yourself, this is valuable information.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyStatGroupDefinition  */
    public UInt32 statGroupHash {get;set;}
    public Dictionary<UInt32, DestinyInventoryItemStatDefinition> stats {get;set;}
    public Boolean hasDisplayable {get;set;}
    public UInt32 primaryBaseStatsHash {get;set;}
    
}
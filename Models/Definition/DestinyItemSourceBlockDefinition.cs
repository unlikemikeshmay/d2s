namespace bulkybook.Models;

public class DestinyItemSourceBlockDefinition
{
    /*  The list of hash identifiers for Reward Sources that hint where the item can be found (DestinyRewardSourceDefinition).
Type: array
Array Contents: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyRewardSourceDefinition  */
    public List<UInt32> sourceHashes {get;set;}
    public List<DestinyItemSourceDefinition> sources {get;set;}
    public Int32 exclusive {get;set;}
    public List<DestinyItemVendorSourceReference> vendorSources {get;set;}

}
namespace bulkybook.Models;

public class DestinyItemInventoryBlockDefinition
{
    public string stackUniqueLabel {get;set;}
    public Int32 maxStackSize {get;set;}
    /*  The hash identifier for the DestinyInventoryBucketDefinition to which this item belongs. I should have named this "bucketHash", but too many things refer to it now. Sigh.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryBucketDefinition  */
    public UInt32 bucketTypeHash {get;set;}
    /*  If the item is picked up by the lost loot queue, this is the hash identifier for the DestinyInventoryBucketDefinition into which it will be placed. Again, I should have named this recoveryBucketHash instead.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryBucketDefinition  */
    public UInt32 recoveryBucketTypeHash {get;set;}
    /*  The hash identifier for the Tier Type of the item, use to look up its DestinyItemTierTypeDefinition if you need to show localized data for the item's tier.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Items.DestinyItemTierTypeDefinition  */
    public UInt32 tierTypeHash {get;set;}
    public Boolean isInstanceItem {get;set;}
    public string tierTypeName {get;set;}
    public Int32 tierType {get;set;}
    public string expirationToolTip {get;set;}
    public string expiredInActivityMessage {get;set;}
    public string expiredInOrbitMessage {get;set;}
    public Boolean suppressExpirationWhenObjectivesComplete {get;set;}
    /*  A reference to the associated crafting 'recipe' item definition, if this item can be crafted.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    public UInt32 recipeItemHash {get;set;}

}
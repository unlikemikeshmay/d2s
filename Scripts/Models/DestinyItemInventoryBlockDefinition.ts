
export interface DestinyItemInventoryBlockDefinition
{
    stackUniqueLabel: string;
    maxStackSize: number;
    /*  The hash identifier for the DestinyInventoryBucketDefinition to which this item belongs. I should have named this "bucketHash", but too many things refer to it now. Sigh.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryBucketDefinition  */
    bucketTypeHash: number;
    /*  If the item is picked up by the lost loot queue, this is the hash identifier for the DestinyInventoryBucketDefinition into which it will be placed. Again, I should have named this recoveryBucketHash instead.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryBucketDefinition  */
    recoveryBucketTypeHash: number;
    /*  The hash identifier for the Tier Type of the item, use to look up its DestinyItemTierTypeDefinition if you need to show localized data for the item's tier.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Items.DestinyItemTierTypeDefinition  */
    tierTypeHash: number;
    isInstanceItem: boolean;
    tierTypeName: string;
    tierType: number;
    expirationToolTip: string;
    expiredInActivityMessage: string;
    expiredInOrbitMessage: string;
    suppressExpirationWhenObjectivesComplete: boolean;
    /*  A reference to the associated crafting 'recipe' item definition, if this item can be crafted.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    recipeItemHash: number;
}
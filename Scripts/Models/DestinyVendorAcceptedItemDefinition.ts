
export interface DestinyVendorAcceptedItemDefinition
{
      /*  The "source" bucket for a transfer. When a user wants to transfer an item, the appropriate DestinyVendorDefinition's acceptedItems property is evaluated, looking for an entry where acceptedInventoryBucketHash matches the bucket that the item being transferred is currently located. If it exists, the item will be transferred into whatever bucket is defined by destinationInventoryBucketHash.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryBucketDefinition  */ 
acceptedInventoryBucketHash: number;
/* 
This is the bucket where the item being transferred will be put, given that it was being transferred *from* the bucket defined in acceptedInventoryBucketHash.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryBucketDefinition  */
destinationInventoryBucketHash: number;
}
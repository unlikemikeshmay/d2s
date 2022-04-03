namespace bulkybook.Models;

public class DestinyVendorSaleItemComponent
{
    public Int32 saleStatus {get;set;}
    public List<UInt32> requiredUnlocks {get;set;}
    public List<DestinyUnlockStatus> unlockStatuses {get;set;}
    public List<Int32> failureIndexes {get;set;}
    public Int32 augments {get;set;}
    public List<Boolean> itemValueVisibility {get;set;}
    public Int32 vendorItemIndex {get;set;}
    // Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition 
    public UInt32 itemHash {get;set;}
    // Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition 
    public UInt32 overrideStyleItemHash {get;set;}
    public Int32 quantity {get;set;}
    public List<DestinyItemQuantity> costs {get;set;}
    public DateTime overrideNextRefreshDate {get;set;}
    public Boolean apiPurchasable {get;set;}

}
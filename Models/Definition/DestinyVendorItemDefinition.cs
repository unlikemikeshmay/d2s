namespace bulkybook.Models;

public class DestinyVendorItemDefinition
{
    public Int32 vendorItemIndex {get;set;}
    /*  The hash identifier of the item being sold (DestinyInventoryItemDefinition).

Note that a vendor can sell the same item in multiple ways, so don't assume that itemHash is a unique identifier for this entity.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    public UInt32 itemHash {get;set;}
    public Int32 quantity {get;set;}
    public List<Int32> failureIndexes {get;set;}
    public List<DestinyVendorItemQuantity> currencies {get;set;}
    public Int32 refundPolicy {get;set;}
    public Int32 refundTimeLimit {get;set;}
    public List<DestinyItemCreationEntryLevelDefinition> creatingLevels {get;set;}
    public Int32 displayCategoryIndex {get;set;}
    public Int32 categoryIndex {get;set;}
    public Int32 originalCategoryIndex {get;set;}
    public Int32 minimumLevel {get;set;}
    public Int32 maximumLevel {get;set;}
    public DestinyVendorSaleItemActionBlockDefinition action {get;set;}
    public string displayCategory {get;set;}
    public UInt32 inventoryBucketHash {get;set;}
    public Int32 visibilityScope {get;set;}
    public Int32 purchasableScope {get;set;}
    public Int32 exclusivity {get;set;}
    public Boolean isOffer {get;set;}
    public Boolean isCrm {get;set;}
    public Int32 sortValue {get;set;}
    public string expirationToolTip {get;set;}
    public List<Int32> redirectToSaleIndexes {get;set;}
    public List<DestinyVendorItemSocketOverride> socketOverrides {get;set;}
    public Boolean unpurchasable {get;set;}
    
}
namespace bulkybook.Models;

public class DestinyVendorDefinition
{
    public DestinyVendorDisplayPropertiesDefinition displayProperties {get;set;}
    public Int32 vendorProgressionType {get;set;}
    public string buyString {get;set;}
    public string sellString {get;set;}
    /*  If the vendor has an item that should be displayed as the "featured" item, this is the hash identifier for that DestinyVendorItemDefinition.

Apparently this is usually a related currency, like a reputation token. But it need not be restricted to that.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    public UInt32 displayItemHash {get;set;}
    public Boolean inhibitBuying {get;set;}
    public Boolean inhibitSelling {get;set;}
    /*  If the Vendor has a faction, this hash will be valid and point to a DestinyFactionDefinition.

The game UI and BNet often mine the faction definition for additional elements and details to place on the screen, such as the faction's Progression status (aka "Reputation").
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyFactionDefinition  */
    public UInt32 factionHash {get;set;}
    public Int32 resetIntervalMinutes {get;set;}
    public Int32 resetOffsetMinutes {get;set;}
    public List<string> failureString {get;set;}
    public List<DateRange> unlockRanges {get;set;}
    public string vendorIdentifier {get;set;}
    public string vendorPortrait {get;set;}
    public string vendorBanner {get;set;}
    public Boolean enabled {get;set;}
    public Boolean visible {get;set;}
    public string vendorSubcategoryIdentifier {get;set;}
    public Boolean consolidateCategories {get;set;}
    public List<DestinyVendorActionDefinition> actions {get;set;}
    public List<DestinyVendorCategoryEntryDefinition> categories {get;set;}
    public List<DestinyDisplayCategoryDefinition> displayCategories {get;set;}
    public List<DestinyVendorInteractionDefinition> interactions {get;set;}
    public List<DestinyVendorItemDefinition> itemList {get;set;}
    public List<DestinyVendorServiceDefinition> services {get;set;}
    public List<DestinyVendorAcceptedItemDefinition> acceptedItems {get;set;}
    public Boolean returnWithVendorRequest {get;set;}
    public List<DestinyVendorLocationDefinition> locations {get;set;}
    public List<DestinyVendorGroupReference> groups {get;set;}
    public List<UInt32> ignoreSaleItemHashes {get;set;}
    public UInt32 hash {get;set;}
    public Int32 index {get;set;}
    public Boolean redacted {get;set;}

}
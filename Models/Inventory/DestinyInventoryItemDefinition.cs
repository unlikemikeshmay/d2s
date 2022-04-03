namespace bulkybook.Models;

public class DestinyInventoryItemDefinition
{
    public DestinyDisplayPropertiesDefinition displayProperties {get;set;}
    public DestinyItemTooltipNotification tooltipNotifications {get;set;}
    /*  Mapped to Manifest Database Definition: Destiny.Definitions.Collectibles.DestinyCollectibleDefinition  */
    public DestinyCollectibleDefinition collectibleHash {get;set;}
    public string iconWatermark {get;set;}
    public string iconWatermarkShelved {get;set;}
    public string secondaryIcon {get;set;}

    public string secondaryOverlay {get;set;}
    public string secondarySpecial {get;set;}
    public DestinyColor backgroundColor {get;set;}
    public string screenShot {get;set;}
    public string itemTypeDisplayName {get;set;}
    public string flavorText {get;set;}
    public string uiItemDisplayStyle {get;set;}
    public string itemTypeAndTierDisplayName {get;set;}
    public string displaySource {get;set;}
    public string tooltipStyle {get;set;}
    public DestinyItemActionBlockDefinition action {get;set;}
    public DestinyItemCraftingBlockDefinition crafting {get;set;}
    public DestinyItemInventoryBlockDefinition inventory {get;set;}
    public DestinyItemSetBlockDefinition setData {get;set;}
    public DestinyItemStatBlockDefinition stats {get;set;}
    /* If the item is an emblem that has a special Objective attached to it - for instance, if the emblem tracks PVP Kills, or what-have-you. This is a bit different from, for example, the Vanguard Kill Tracker mod, which pipes data into the "art channel". When I get some time, I would like to standardize these so you can get at the values they expose without having to care about what they're being used for and how they are wired up, but for now here's the raw data.  */
    public UInt32 emblemObjectiveHash {get;set;}
    public DestinyEquippingBlockDefinition equippingBlock {get;set;}
    public DestinyItemTranslationBlockDefinition translationBlock {get;set;}
    public DestinyItemPreviewBlockDefinition preview {get;set;}
    public DestinyItemQualityBlockDefinition quality {get;set;}
    public DestinyItemValueBlockDefinition value {get;set;}
    public DestinyItemSourceBlockDefinition sourceData {get;set;}
    public DestinyItemObjectiveBlockDefinition objectives {get;set;}
    public DestinyItemMetricBlockDefinition metrics {get;set;}
    public DestinyItemPlugDefinition plug {get;set;}
    public DestinyItemGearsetBlockDefinition gearset {get;set;}
    public DestinyItemSackBlockDefinition sack {get;set;}
    public DestinyItemSocketBlockDefinition sockets {get;set;}
    public DestinyItemSummaryBlockDefinition summary {get;set;}
    public DestinyItemTalentGridBlockDefinition talentGrid {get;set;}
    public List<DestinyItemInvestmentStatDefinition> investmentStats {get;set;}
    public List<DestinyItemPerkEntryDefinition> perks {get;set;} 
    public Dictionary<UInt32, DestinyLoreDefinition> loreHash {get;set;}
    /*  Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    public UInt32 summaryItemHash {get;set;}
    public List<DestinyAnimationReference> animations {get;set;}
    public Boolean allowActions {get;set;}
    public List<HyperlinkReference> links {get;set;}
    public Boolean doesPostmasterPullHaveSideEffects {get;set;}
    public Boolean nonTransferrable {get;set;}
    /*  Mapped to Manifest Database Definition: Destiny.Definitions.DestinyItemCategoryDefinition  */
    public List<UInt32> itemCategoryHashes {get;set;}
    public Int32 specialItemType {get;set;}
    public Int32 itemType {get;set;}
    public Int32 itemSubType {get;set;}
    public Int32 classType {get;set;}
    public Int32 breakerType {get;set;}
    /*  Since we also have a breaker type definition, this is the hash for that breaker type for your convenience. Whether you use the enum or hash and look up the definition depends on what's cleanest for your code.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.BreakerTypes.DestinyBreakerTypeDefinition  */
    public UInt32 breakerTypeHash {get;set;}
    public Boolean equippable {get;set;}
    /*  Theoretically, an item can have many possible damage types. In *practice*, this is not true, but just in case weapons start being made that have multiple (for instance, an item where a socket has reusable plugs for every possible damage type that you can choose from freely), this field will return all of the possible damage types that are available to the weapon by default.
Type: array
Array Contents: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyDamageTypeDefinition  */
    public List<UInt32> damageTypeHashes {get;set;}

    public UInt32 seasonHash {get;set;}
    public Boolean isWrapper {get;set;}
    public List<string> traitIds {get;set;}
    public List<UInt32> traitHashes {get;set;}
    public UInt32 hash {get;set;}
    public Int32 index {get;set;}
    public Boolean redacted {get;set;}

}
using System.Text.Json.Serialization;

namespace bulkybook.Models;
public class DestinyProfileResponse
{
    [JsonPropertyName("vendorReceipts")]
    public SingleComponentResponseOfDestinyVendorReceiptsComponent vendorReceipts {get;set;}
    [JsonPropertyName("profileInventory")]
    public SingleComponentResponseOfDestinyInventoryComponent profileInventory {get;set;}
    [JsonPropertyName("profileCurrencies")]
    public SingleComponentResponseOfDestinyInventoryComponent profileCurrencies {get;set;}
    [JsonPropertyName("profile")]
    public SingleComponentResponseOfDestinyProfileComponent profile {get;set;}
    [JsonPropertyName("platformSilver")]
    public SingleComponentResponseOfDestinyPlatformSilverComponent platformSilver {get;set;}
    [JsonPropertyName("profileKiosks")]
    public SingleComponentResponseOfDestinyKiosksComponent profileKiosks {get;set;}
    [JsonPropertyName("profilePlugSets")]
    public SingleComponentResponseOfDestinyPlugSetsComponent profilePlugSets {get;set;}
    [JsonPropertyName("profileProgression")]
    public SingleComponentResponseOfDestinyProfileProgressionComponent profileProgression {get;set;}
    [JsonPropertyName("profilePresentationNodes")]
    public SingleComponentResponseOfDestinyPresentationNodesComponent profilePresentationNodes {get;set;}
    [JsonPropertyName("profileRecords")]
    public SingleComponentResponseOfDestinyProfileRecordsComponent profileRecords {get;set;}
    [JsonPropertyName("profileCollectibles")]
    public SingleComponentResponseOfDestinyProfileCollectiblesComponent profileCollectibles {get;set;}
    [JsonPropertyName("profileTransitoryData")]
    public SingleComponentResponseOfDestinyProfileTransitoryComponent profileTransitoryData {get;set;}
    [JsonPropertyName("metrics")]
    public SingleComponentResponseOfDestinyMetricsComponent metrics {get;set;}
    [JsonPropertyName("profileStringVariables")]
    public SingleComponentResponseOfDestinyStringVariablesComponent profileStringVariables {get;set;}
    [JsonPropertyName("characters")]
    public DictionaryComponentResponseOfint64AndDestinyCharacterComponent characters {get;set;}
    [JsonPropertyName("characterInventories")]
    public DictionaryComponentResponseOfint64AndDestinyInventoryComponent characterInventories {get;set;}
    [JsonPropertyName("characterProgressions")]
    public DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent characterProgressions {get;set;}
    [JsonPropertyName("characterRenderData")]
    public DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent characterRenderData {get;set;}
    [JsonPropertyName("characterActivities")]
    public DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent characterActivities {get;set;}
    [JsonPropertyName("characterEquipment")]
    public  DictionaryComponentResponseOfint64AndDestinyInventoryComponent characterEquipment {get;set;}
    [JsonPropertyName("characterKiosks")]
    public DictionaryComponentResponseOfint64AndDestinyKiosksComponent characterKiosks {get;set;}
    [JsonPropertyName("characterPlugSets")]
    public DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent characterPlugSets {get;set;}
    [JsonPropertyName("characterUninstancedItemComponents")]
    public Dictionary<Int64,DestinyBaseItemComponentSetOfuint32> characterUninstancedItemComponents {get;set;}
    [JsonPropertyName("characterPresentationNodes")]
    public DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent characterPresentationNodes {get;set;}
    [JsonPropertyName("characterRecords")]
    public DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent characterRecords {get;set;}
    [JsonPropertyName("characterCollectibles")]
    public DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent characterCollectibles {get;set;}
    [JsonPropertyName("characterStringVariables")]
    public DictionaryComponentResponseOfint64AndDestinyStringVariablesComponent characterStringVariables {get;set;}
    [JsonPropertyName("characterCraftables")]
    public DictionaryComponentResponseOfint64AndDestinyCraftablesComponent characterCraftables {get;set;}
    [JsonPropertyName("itemComponents")]
    public DestinyItemComponentSetOfint64 itemComponents {get;set;}
    [JsonPropertyName("characterCurrencyLookups")]
    public DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent characterCurrencyLookups {get;set;}
    

}   
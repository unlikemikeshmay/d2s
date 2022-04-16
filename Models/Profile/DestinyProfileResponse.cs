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
    public SingleComponentResponseOfDestinyPlatformSilverComponent platformSilver {get;set;}
    public SingleComponentResponseOfDestinyKiosksComponent profileKiosks {get;set;}
    public SingleComponentResponseOfDestinyPlugSetsComponent profilePlugSets {get;set;}
    public SingleComponentResponseOfDestinyProfileProgressionComponent profileProgression {get;set;}
    public SingleComponentResponseOfDestinyPresentationNodesComponent profilePresentationNodes {get;set;}
    public SingleComponentResponseOfDestinyProfileRecordsComponent profileRecords {get;set;}
    public SingleComponentResponseOfDestinyProfileCollectiblesComponent profileCollectibles {get;set;}
    public SingleComponentResponseOfDestinyProfileTransitoryComponent profileTransitoryData {get;set;}
    public SingleComponentResponseOfDestinyMetricsComponent metrics {get;set;}
    public SingleComponentResponseOfDestinyStringVariablesComponent profileStringVariables {get;set;}
    public DictionaryComponentResponseOfint64AndDestinyCharacterComponent characters {get;set;}
    public DictionaryComponentResponseOfint64AndDestinyInventoryComponent characterInventories {get;set;}
    public DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent characterProgressions {get;set;}
    public DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent characterRenderData {get;set;}
    public DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent characterActivities {get;set;}
    public  DictionaryComponentResponseOfint64AndDestinyInventoryComponent characterEquipment {get;set;}
    public DictionaryComponentResponseOfint64AndDestinyKiosksComponent characterKiosks {get;set;}
    public DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent characterPlugSets {get;set;}
    public Dictionary<Int64,DestinyBaseItemComponentSetOfuint32> characterUninstancedItemComponents {get;set;}
    public DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent characterPresentationNodes {get;set;}
    public DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent characterRecords {get;set;}
    public DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent characterCollectibles {get;set;}
    public DictionaryComponentResponseOfint64AndDestinyStringVariablesComponent characterStringVariables {get;set;}
    public DictionaryComponentResponseOfint64AndDestinyCraftablesComponent characterCraftables {get;set;}
    public DestinyItemComponentSetOfint64 itemComponents {get;set;}
    public DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent characterCurrencyLookups {get;set;}
    

}   
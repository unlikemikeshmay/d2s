namespace bulkybook.Models;

public class DestinyVendorsResponse
{
    public DestinyVendorGroup vendorGroups {get;set;}
    public DictionaryComponentResponseOfuint32AndDestinyVendorComponent vendors {get;set;}
    public DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent categories {get;set;}
    public DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent sales {get;set;}
    public Dictionary<UInt32,DestinyItemComponentSetOfint32> itemComponents {get;set;}
    public SingleComponentResponseOfDestinyCurrenciesComponent currencyLookups {get;set;}
    public SingleComponentResponseOfDestinyStringVariablesComponent stringVariables {get;set;}
}
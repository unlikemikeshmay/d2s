namespace bulkybook.Models;

public class DestinyVendorComponent
{
    public Boolean canPurchase {get;set;}

    public DestinyProgression progression {get;set;}
    public Int32 vendorLocationIndex {get;set;}
    public Int32 seasonalRank {get;set;}
    public DestinyVendorGroupDefinition vendorHash {get;set;}
}
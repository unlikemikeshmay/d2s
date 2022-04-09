namespace bulkybook.Models;

public class DestinyVendorItemQuantity
{
    public UInt32 itemHash {get;set;}
    public Int64 itemInstanceId {get;set;}
    public Int32 quantity {get;set;}
    public Boolean hasConditionalVisibility {get;set;}
}
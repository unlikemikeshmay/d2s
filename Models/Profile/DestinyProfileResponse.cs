namespace bulkybook.Models;
public class DestinyProfileResponse
{
    public SingleComponentResponseOfDestinyVendorReceiptsComponent vendorReceipts {get;set;}
    public SingleComponentResponseOfDestinyInventoryComponent profileInventory {get;set;}
    public SingleComponentResponseOfDestinyInventoryComponent profileCurrencies {get;set;}
    public SingleComponentResponseOfDestinyProfileComponent profile {get;set;}
}   
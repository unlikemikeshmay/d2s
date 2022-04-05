namespace bulkybook.Models;

public class DestinyItemPreviewBlockDefinition
{
    public string screenStyle {get;set;}
    /*  If the preview data is derived from a fake "Preview" Vendor, this will be the hash identifier for the DestinyVendorDefinition of that fake vendor.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyVendorDefinition  */
    public UInt32 previewVendorHash {get;set;}
    public string previewActionString {get;set;}
    public List<DestinyDerivedItemCategoryDefinition> derivedItemCategories {get;set;}
}
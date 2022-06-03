import { DestinyDerivedItemCategoryDefinition } from "./DestinyDerivedItemCategoryDefinition";
export interface DestinyItemPreviewBlockDefinition
{
    screenStyle: string;
    /*  If the preview data is derived from a fake "Preview" Vendor, this will be the hash identifier for the DestinyVendorDefinition of that fake vendor.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyVendorDefinition  */
    previewVendorHash: number;
    previewActionString: string;
    derivedItemCategories: Array<DestinyDerivedItemCategoryDefinition>;
}
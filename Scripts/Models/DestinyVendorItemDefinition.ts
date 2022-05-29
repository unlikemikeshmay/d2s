import { DestinyVendorItemQuantity } from "./DestinyVendorItemQuantity";
import { DestinyItemCreationEntryLevelDefinition } from "./DestinyItemCreationEntryLevelDefinition";
import { DestinyVendorSaleItemActionBlockDefinition } from "./DestinyVendorSaleItemActionBlockDefinition";
import { DestinyVendorItemSocketOverride } from "./DestinyVendorItemSocketOverride";
export interface DestinyVendorItemDefinition
{
    vendorItemIndex:number;
    /*  The hash identifier of the item being sold (DestinyInventoryItemDefinition).

Note that a vendor can sell the same item in multiple ways, so don't assume that itemHash is a unique identifier for this entity.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    itemHash:number;
    quantity:number;
    failureIndexes: Array<number>;
    currencies: Array<DestinyVendorItemQuantity>;
    refundPolicy:number;
    refundTimeLimit:number;
    creatingLevels: Array<DestinyItemCreationEntryLevelDefinition>;
    displayCategoryIndex:number;
    categoryIndex:number;
    originalCategoryIndex:number;
    minimumLevel:number;
    maximumLevel:number;
    action:DestinyVendorSaleItemActionBlockDefinition;
    displayCategory:string;
    inventoryBucketHash:number;
    visibilityScope:number;
    purchasableScope:number;
    exclusivity:number;
    isOffer:boolean;
    isCrm:boolean;
    sortValue:number;
    expirationToolTip:string;
    redirectToSaleIndexes: Array<number>;
    socketOverrides: Array<DestinyVendorItemSocketOverride>;
    unpurchasable: boolean;
}
import { DestinyVendorDisplayPropertiesDefinition } from "./DestinyVendorDisplayPropertiesDefinition";
import { DateRange } from "./DateRange";
import { DestinyVendorActionDefinition } from "./DestinyVendorActionDefinition";
import { DestinyVendorCategoryEntryDefinition } from "./DestinyVendorCategoryEntryDefinition";
import { DestinyDisplayCategoryDefinition } from "./DestinyDisplayCategoryDefinition";
import { DestinyVendorInteractionDefinition } from "./DestinyVendorInteractionDefinition";
import { DestinyVendorItemDefinition } from "./DestinyVendorItemDefinition";
import { DestinyVendorServiceDefinition } from "./DestinyVendorServiceDefinition";
import { DestinyVendorAcceptedItemDefinition } from "./DestinyVendorAcceptedItemDefinition";
import { DestinyVendorLocationDefinition } from "./DestinyVendorLocationDefinition";
import { DestinyVendorGroupReference } from "./DestinyVendorGroupReference";
export interface DestinyVendorDefinition
{
    displayProperties: DestinyVendorDisplayPropertiesDefinition;
    vendorProgressionType: number;
    buyString: string;
    sellString: string;
    /*  If the vendor has an item that should be displayed as the "featured" item, this is the hash identifier for that DestinyVendorItemDefinition.

Apparently this is usually a related currency, like a reputation token. But it need not be restricted to that.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    displayItemHash: number;
    inhibitBuying: boolean;
    inhibitSelling: boolean;
    /*  If the Vendor has a faction, this hash will be valid and point to a DestinyFactionDefinition.

The game UI and BNet often mine the faction definition for additional elements and details to place on the screen, such as the faction's Progression status (aka "Reputation").
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyFactionDefinition  */
    factionHash: number;
    resetIntervalMinutes: number;
    resetOffsetMinutes: number;
    failureString: Array<string>;
    unlockRanges: Array<DateRange>;
    vendorIdentifier: string;
    vendorPortrait: string;
    vendorBanner:string;
    enabled: boolean;
    visible: boolean;
    vendorSubcategoryIdentifier: string;
    consolidateCategories: boolean;
    actions: Array<DestinyVendorActionDefinition>;
    categories: Array<DestinyVendorCategoryEntryDefinition>;
    displayCategories: Array<DestinyDisplayCategoryDefinition>;
    interactions: Array<DestinyVendorInteractionDefinition>;
    itemList: Array<DestinyVendorItemDefinition>;
    services: Array<DestinyVendorServiceDefinition>;
    acceptedItems: Array<DestinyVendorAcceptedItemDefinition>;
    returnWithVendorRequest: Boolean;
    locations: Array<DestinyVendorLocationDefinition>;
    groups: Array<DestinyVendorGroupReference>;
    ignoreSaleItemHashes: Array<number>;
    hash: number;
    index: number;
    redacted: boolean;
}
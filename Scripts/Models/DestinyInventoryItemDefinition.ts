import { DestinyColor } from "./DestinyColor";
import { DestinyDisplayPropertiesDefinition } from "./DestinyDisplayPropertiesDefinition";
import { DestinyItemTooltipNotification } from "./DestinyItemTooltipNotification";
import { DestinyCollectibleDefinition } from "./DestinyCollectibleDefinition";
import { DestinyItemActionBlockDefinition } from "./DestinyItemActionBlockDefinition";
import { DestinyItemCraftingBlockDefinition } from "./DestinyItemCraftingBlockDefinition";
import { DestinyItemInventoryBlockDefinition } from "./DestinyItemInventoryBlockDefinition";
import { DestinyItemSetBlockDefinition } from "./DestinyItemSetBlockDefinition";
import { DestinyItemStatBlockDefinition } from "./DestinyItemStatBlockDefinition";
import { DestinyEquippingBlockDefinition } from "./DestinyEquippingBlockDefinition";
import { DestinyItemTranslationBlockDefinition } from "./DestinyItemTranslationBlockDefinition";
import { DestinyItemPreviewBlockDefinition } from "./DestinyItemPreviewBlockDefinition";
import { DestinyItemQualityBlockDefinition } from "./DestinyItemQualityBlockDefinition";
import { DestinyItemValueBlockDefinition } from "./DestinyItemValueBlockDefinition";
import { DestinyItemSourceBlockDefinition } from "./DestinyItemSourceBlockDefinition";
import { DestinyItemObjectiveBlockDefinition } from "./DestinyItemObjectiveBlockDefinition";
import { DestinyItemMetricBlockDefinition } from "./DestinyItemMetricBlockDefinition";
import { DestinyItemPlugDefinition } from "./DestinyItemPlugDefinition";
import { DestinyItemGearsetBlockDefinition } from "./DestinyItemGearsetBlockDefinition";
import { DestinyItemSackBlockDefinition } from "./DestinyItemSackBlockDefinition";
import { DestinyItemSocketBlockDefinition } from "./DestinyItemSocketBlockDefinition";
import { DestinyItemSummaryBlockDefinition } from "./DestinyItemSummaryBlockDefinition";
import { DestinyItemTalentGridBlockDefinition } from "./DestinyItemTalentGridBlockDefinition";
import { DestinyItemInvestmentStatDefinition } from "./DestinyItemInvestmentStatDefinition";
import { DestinyItemPerkEntryDefinition } from "./DestinyItemPerkEntryDefinition";
import { DestinyLoreDefinition } from "./DestinyLoreDefinition";
import { DestinyAnimationReference } from "./DestinyAnimationReference";
import { HyperlinkReference } from "./HyperlinkReference";
export interface DestinyInventoryItemDefinition
{
    displayProperties: DestinyDisplayPropertiesDefinition;
    tooltipNotifications: DestinyItemTooltipNotification;
    /*  Mapped to Manifest Database Definition: Destiny.Definitions.Collectibles.DestinyCollectibleDefinition  */
    collectibleHash: DestinyCollectibleDefinition;
    iconWatermark: string;
    iconWatermarkShelved: string
    secondaryIcon: string

    secondaryOverlay: string
    secondarySpecial: string
    backgroundColor: DestinyColor;
    screenShot: string
    itemTypeDisplayName: string
    flavorText: string
    uiItemDisplayStyle: string
    itemTypeAndTierDisplayName: string
    displaySource: string
    tooltipStyle: string
    action: DestinyItemActionBlockDefinition;
    crafting: DestinyItemCraftingBlockDefinition ;
    inventory: DestinyItemInventoryBlockDefinition;
    setData: DestinyItemSetBlockDefinition;
    stats: DestinyItemStatBlockDefinition;
    /* If the item is an emblem that has a special Objective attached to it - for instance, if the emblem tracks PVP Kills, or what-have-you. This is a bit different from, for example, the Vanguard Kill Tracker mod, which pipes data into the "art channel". When I get some time, I would like to standardize these so you can get at the values they expose without having to care about what they're being used for and how they are wired up, but for now here's the raw data.  */
    emblemObjectiveHash: number;
    equippingBlock:DestinyEquippingBlockDefinition;
    translationBlock: DestinyItemTranslationBlockDefinition;
    preview: DestinyItemPreviewBlockDefinition;
    quality: DestinyItemQualityBlockDefinition;
    value: DestinyItemValueBlockDefinition;
    sourceData: DestinyItemSourceBlockDefinition;
    objectives: DestinyItemObjectiveBlockDefinition;
    metrics:  DestinyItemMetricBlockDefinition;
    plug: DestinyItemPlugDefinition;
    gearset: DestinyItemGearsetBlockDefinition;
    sack: DestinyItemSackBlockDefinition;
    sockets: DestinyItemSocketBlockDefinition;
    summary: DestinyItemSummaryBlockDefinition;
    talentGrid: DestinyItemTalentGridBlockDefinition;
    investmentStats: Array<DestinyItemInvestmentStatDefinition>;
    perks: Array<DestinyItemPerkEntryDefinition>;
    loreHash: Map<number, DestinyLoreDefinition> ;
    /*  Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    summaryItemHash: number;
    animations: Array<DestinyAnimationReference>;
    allowActions: boolean;
    links: Array<HyperlinkReference>;
    doesPostmasterPullHaveSideEffects: boolean;
    nonTransferrable: boolean;
    /*  Mapped to Manifest Database Definition: Destiny.Definitions.DestinyItemCategoryDefinition  */
    itemCategoryHashe: Array<number>;
    specialItemType: number;
    itemType: number;
    itemSubType: number;
    classType: number;
    breakerType: number;
    /*  Since we also have a breaker type definition, this is the hash for that breaker type for your convenience. Whether you use the enum or hash and look up the definition depends on what's cleanest for your code.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.BreakerTypes.DestinyBreakerTypeDefinition  */
    breakerTypeHash: number;
    equippable: boolean;
    /*  Theoretically, an item can have many possible damage types. In *practice*, this is not true, but just in case weapons start being made that have multiple (for instance, an item where a socket has reusable plugs for every possible damage type that you can choose from freely), this field will return all of the possible damage types that are available to the weapon by default.
Type: array
Array Contents: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyDamageTypeDefinition  */
    damageTypeHashes: Array<number>;

    seasonHash: number;
    isWrapper: boolean;
    traitIds: Array<string>;
    traitHashes: Array<number>;
    hash: number;
    index: number;
    redacted: boolean;
}
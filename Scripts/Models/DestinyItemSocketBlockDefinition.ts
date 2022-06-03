import { DestinyItemSocketEntryDefinition } from "./DestinyItemSocketEntryDefinition";
import { DestinyItemIntrinsicSocketEntryDefinition } from "./DestinyItemIntrinsicSocketEntryDefinition";
import { DestinyItemSocketCategoryDefinition } from "./DestinyItemSocketCategoryDefinition";
export interface DestinyItemSocketBlockDefinition
{
    detail: string;
    socketEntries: Array<DestinyItemSocketEntryDefinition>;
    intrinsicSockets: Array<DestinyItemIntrinsicSocketEntryDefinition>;
    socketCategories:  Array<DestinyItemSocketCategoryDefinition>;
}
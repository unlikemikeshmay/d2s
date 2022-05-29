import { DestinyDisplayPropertiesDefinition } from "./DestinyDisplayPropertiesDefinition";
import { DestinyItemSocketEntryPlugItemRandomizedDefinition } from "./DestinyItemSocketEntryPlugItemRandomizedDefinition";
export interface DestinyPlugSetDefinition
{
    displayProperties: DestinyDisplayPropertiesDefinition;
    reusablePlugItems: Array<DestinyItemSocketEntryPlugItemRandomizedDefinition>;
    isFakePlugSet: boolean;
    hash: number;
    index: number;
    redacted: boolean;
}
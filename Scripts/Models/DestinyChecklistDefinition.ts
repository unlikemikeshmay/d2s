import { DestinyDisplayPropertiesDefinition } from "./DestinyDisplayPropertiesDefinition";
import { DestinyChecklistEntryDefinition } from "./DestinyChecklistEntryDefinition";
export interface DestinyChecklistDefinition
{
    displayProperties: DestinyDisplayPropertiesDefinition;
    viewActionString: string;
    scope: number;
    entries: Array<DestinyChecklistEntryDefinition>;
    hash: number;
    index: number;
    redacted: boolean;
}
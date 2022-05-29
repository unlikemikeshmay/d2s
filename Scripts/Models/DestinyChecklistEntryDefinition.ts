import { DestinyDisplayPropertiesDefinition } from "./DestinyDisplayPropertiesDefinition";
export interface DestinyChecklistEntryDefinition
{
    hash: number;
    displayProperties: DestinyDisplayPropertiesDefinition;
    destinationHash: number;
    /*  Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyLocationDefinition  */
    locationHash: number;
    bubbleHash: number;
    activityHash: number;
    vendorHash: number;
    vendorInteractionIndex: number;
    scope: number;
}
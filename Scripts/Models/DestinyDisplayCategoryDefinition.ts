import { DestinyDisplayPropertiesDefinition } from "./DestinyDisplayPropertiesDefinition";
export interface DestinyDisplayCategoryDefinition
{
    index: number;
    identifier: string;
    displayCategoryHash:number;
    displayProperties: DestinyDisplayPropertiesDefinition;
    displayInBanner: boolean;
    /*  If it exists, this is the hash identifier of a DestinyProgressionDefinition that represents the progression to show on this display category.

Specific categories can now have thier own distinct progression, apparently. So that's cool.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyProgressionDefinition  */
    progressionHash: number;
    sortOrder: number;
    displayStyleHash: number;
    displayStyleIdentifier: string;
}
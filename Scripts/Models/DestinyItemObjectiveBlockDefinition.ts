import { DestinyObjectiveDisplayProperties } from "./DestinyObjectiveDisplayProperties";
export interface DestinyItemObjectiveBlockDefinition
{
    objectiveHashes: Array<number>;
    displayActivityHashes: Array<number>;
    requireFullObjectiveCompletion: boolean;
    /*  The hash for the DestinyInventoryItemDefinition representing the Quest to which this Quest Step belongs.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    questlineItemHash: number;
    narrative: string;
    objectiveVerbName: string;
    questTypeIdentifier: string;
    questTypeHash: number;
    perObjectiveDisplayProperties: Array<DestinyObjectiveDisplayProperties>;
    displayAsStatTracker: boolean;y
}
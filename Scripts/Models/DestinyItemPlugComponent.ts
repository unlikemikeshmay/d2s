import { DestinyObjectiveProgress } from "./DestinyObjectiveProgress";
export interface DestinyItemPlugComponent
{
    plugObjectives: Array<DestinyObjectiveProgress>;
    /*  The hash identifier of the DestinyInventoryItemDefinition that represents this plug.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    plugItemHash: number;
    canInsert: boolean;
    enabled: boolean;
    insertFailIndexes: Array<number>;
    enableFailIndexes: Array<number>;
}
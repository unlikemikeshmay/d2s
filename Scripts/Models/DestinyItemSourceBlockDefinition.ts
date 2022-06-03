import { DestinyItemSourceDefinition } from "./DestinyItemSourceDefinition";
import { DestinyItemVendorSourceReference } from "./DestinyItemVendorSourceReference";
export interface DestinyItemSourceBlockDefinition
{
     /*  The list of hash identifiers for Reward Sources that hint where the item can be found (DestinyRewardSourceDefinition).
Type: array
Array Contents: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyRewardSourceDefinition  */
sourceHashes: Array<number>;
sources: Array<DestinyItemSourceDefinition>;
exclusive: number;
vendorSources: Array<DestinyItemVendorSourceReference>;
}
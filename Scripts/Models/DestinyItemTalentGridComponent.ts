import { DestinyTalentNode } from "./DestinyTalentNode";
import { DestinyProgression } from "./DestinyProgression";
export interface DestinyItemTalentGridComponent
{
       /*  Most items don't have useful talent grids anymore, but Builds in particular still do.

You can use this hash to lookup the DestinyTalentGridDefinition attached to this item, which will be crucial for understanding the node values on the item.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyTalentGridDefinition  */
talentGridHash: number;
nodes: Array<DestinyTalentNode>;
isGridComplete: boolean;
gridProgression: DestinyProgression;
}
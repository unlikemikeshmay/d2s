import { DestinyCollectibleComponent } from "./DestinyCollectibleComponent";
export interface DestinyProfileCollectiblesComponent
{
       /*  The list of collectibles determined by the game as having been "recently" acquired.
Type: array
Array Contents: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Collectibles.DestinyCollectibleDefinition  */

recentCollectibleHashes: Array<number>;
newnessFlaggedCollectibleHashes: Array<number>;
collectibles: Map<number,DestinyCollectibleComponent>;
collectionCategoriesRootNodeHash: number;
/*  The hash for the root presentation node definition of Collection Badges.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Presentation.DestinyPresentationNodeDefinition  */
collectionBadgesRootNodeHash: number;
}
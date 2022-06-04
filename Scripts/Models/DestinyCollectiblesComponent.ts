import { DestinyCollectibleComponent } from "./DestinyCollectibleComponent";
export interface DestinyCollectiblesComponent
{
      /*  Type: object
Dictionary Contents: Destiny.Components.Collectibles.DestinyCollectibleComponent
Dictionary Key Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Collectibles.DestinyCollectibleDefinition  */
collectibles: Map<number, DestinyCollectibleComponent> ;
collectionCategoriesRootNodeHash: number;
/*  The hash for the root presentation node definition of Collection Badges.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Presentation.DestinyPresentationNodeDefinition  */
collectionBadgesRootNodeHash: number;
}
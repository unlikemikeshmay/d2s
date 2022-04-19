namespace bulkybook.Models;

public class DestinyCollectiblesComponent
{
    /*  Type: object
Dictionary Contents: Destiny.Components.Collectibles.DestinyCollectibleComponent
Dictionary Key Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Collectibles.DestinyCollectibleDefinition  */
    public Dictionary<UInt32, DestinyCollectibleComponent> collectibles {get;set;}
    public UInt32 collectionCategoriesRootNodeHash {get;set;}
    /*  The hash for the root presentation node definition of Collection Badges.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Presentation.DestinyPresentationNodeDefinition  */
    public UInt32 collectionBadgesRootNodeHash {get;set;}

}
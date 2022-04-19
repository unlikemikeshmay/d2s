namespace bulkybook.Models;

public class DestinyProfileCollectiblesComponent
{
    /*  The list of collectibles determined by the game as having been "recently" acquired.
Type: array
Array Contents: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Collectibles.DestinyCollectibleDefinition  */

    public List<UInt32> recentCollectibleHashes {get;set;}
    public List<UInt32> newnessFlaggedCollectibleHashes {get;set;}
    public Dictionary<UInt32,DestinyCollectibleComponent> collectibles {get;set;}
    public UInt32 collectionCategoriesRootNodeHash {get;set;}
    /*  The hash for the root presentation node definition of Collection Badges.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Presentation.DestinyPresentationNodeDefinition  */
    public UInt32 collectionBadgesRootNodeHash {get;set;}

}
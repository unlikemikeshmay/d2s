namespace bulkybook.Models;

public class DestinyCharacterRecordsComponent
{
    /*  Type: array
Array Contents: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Records.DestinyRecordDefinition  */
    public List<UInt32> featuredRecordHashes {get;set;}
    public Dictionary<UInt32,DestinyRecordComponent> records {get;set;}
    /*  The hash for the root presentation node definition of Triumph categories.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Presentation.DestinyPresentationNodeDefinition  */
    public UInt32 recordCategoriesRootNodeHash {get;set;}
    /*  The hash for the root presentation node definition of Triumph Seals.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Presentation.DestinyPresentationNodeDefinition  */
    public UInt32 recordSealsRootNodeHash {get;set;}
}
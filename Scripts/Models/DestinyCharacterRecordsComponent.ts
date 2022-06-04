import { DestinyRecordComponent } from "./DestinyRecordComponent";
export interface DestinyCharacterRecordsComponent
{
      /*  Type: array
Array Contents: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Records.DestinyRecordDefinition  */
featuredRecordHashes: Array<number>;
records: Map<number,DestinyRecordComponent>;
/*  The hash for the root presentation node definition of Triumph categories.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Presentation.DestinyPresentationNodeDefinition  */
recordCategoriesRootNodeHash: number;
/*  The hash for the root presentation node definition of Triumph Seals.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Presentation.DestinyPresentationNodeDefinition  */
recordSealsRootNodeHash: number;
}
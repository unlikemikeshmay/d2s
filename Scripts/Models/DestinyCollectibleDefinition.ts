import { DestinyDisplayPropertiesDefinition } from "./DestinyDisplayPropertiesDefinition";
import { DestinyCollectibleAcquisitionBlock } from "./DestinyCollectibleAcquisitionBlock";
import { DestinyCollectibleStateBlock } from "./DestinyCollectibleStateBlock";
import { DestinyPresentationChildBlock } from "./DestinyPresentationChildBlock";
export interface DestinyCollectibleDefinition
{
    displayProperties: DestinyDisplayPropertiesDefinition;
    scope: number;
    sourceString: string;
    sourceHash: number;
    //mapped to DestinyInventoryItemDefinition
    itemHash: number;
    acquisitionInfo: DestinyCollectibleAcquisitionBlock;

    stateInfo: DestinyCollectibleStateBlock;
    presentationInfo: DestinyPresentationChildBlock;
    presentationNodeType: number;
    traitIds: Array<string>;
    traitHashes: Array<number>;
    parentNodeHashes: Array<number>;
    hash: number;
    index: number;
    redacted: boolean;
}
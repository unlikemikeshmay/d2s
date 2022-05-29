import { DestinyIconSequenceDefinition } from "./DestinyIconSequenceDefinition";
export interface DestinyDisplayPropertiesDefinition
{
    description: string;
    name: string;
    icon: string;
    iconSequences: Array<DestinyIconSequenceDefinition>;
    highResIcon: string;
    hasIcon: boolean;
}
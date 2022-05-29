import { DestinyVendorRequirementDisplayEntryDefinition } from "./DestinyVendorRequirementDisplayEntryDefinition";
import { DestinyIconSequenceDefinition } from "./DestinyIconSequenceDefinition";
export interface DestinyVendorDisplayPropertiesDefinition
{
    largeIcon: string;
    subtitle: string;
    originalIcon: string;
    requirementsDisplay: DestinyVendorRequirementDisplayEntryDefinition;
    smallTransparentIcon: string;
    mapIcon: string;
    largeTransparentIcon: string;
    description: string;
    name: string;
    icon: string;
    iconSequences: DestinyIconSequenceDefinition;
    highResIcon: string;
    hasIcon: boolean;
}
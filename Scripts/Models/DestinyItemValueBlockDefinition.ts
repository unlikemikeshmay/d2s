import { DyeReference } from "./DyeReference";
import { DestinyGearArtArrangementReference } from "./DestinyGearArtArrangementReference";
export interface DestinyItemValueBlockDefinition
{
    weaponPatternIdentifier: string;
    weaponPatternHash: number;
    defaultDyes: Array<DyeReference>;
    lockedDyes: Array<DyeReference>;
    pcustomDyes: Array<DyeReference>;
    arrangements: Array<DestinyGearArtArrangementReference>;
    hasGeometry: boolean;
}
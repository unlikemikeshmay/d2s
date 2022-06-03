import { DyeReference } from "./DyeReference";
import { DestinyGearArtArrangementReference } from "./DestinyGearArtArrangementReference";
export interface DestinyItemTranslationBlockDefinition
{
    weaponPatternIdentifier: string;
    weaponPatternHash: number;
    defaultDyes: Array<DyeReference>;
    lockedDyes: Array<DyeReference>;
    customDyesArray: Array<DyeReference>;
    arrangements:  Array<DestinyGearArtArrangementReference>;
    hasGeometry: boolean;
}
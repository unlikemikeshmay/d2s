import { DestinyColor } from "./DestinyColor";
import { DestinyProgression } from "./DestinyProgression";
export interface DestinyCharacterComponent
{
    membershipId: number;
    membershipType: number;
    characterId: number;
    dateLastPlayed: Date;
    minutesPlayedThisSession: number;
    minutesPlayedTotal: number;
    light: number;
     stats: Map<number,number>;

    /*  Use this hash to look up the character's DestinyRaceDefinition.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyRaceDefinition  */
    raceHash: number;
    /*  Use this hash to look up the character's DestinyGenderDefinition.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyGenderDefinition  */
    genderHash: number;
    classHash: number;
    raceType: number;
    classType: number;
    genderType: number;
    /*  The hash of the currently equipped emblem for the user. Can be used to look up the DestinyInventoryItemDefinition.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    emblemPath: string;
    emblemBackgroundPath: string;
    emblemHash: number;
    emblemColor: DestinyColor;
    levelProgression: DestinyProgression;
    baseCharacterLevel: number;
    percentToNextLevel: number;
    /*  If this Character has a title assigned to it, this is the identifier of the DestinyRecordDefinition that has that title information.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Records.DestinyRecordDefinition  */
    titleRecordHash: number;
}
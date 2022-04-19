namespace bulkybook.Models;

public class DestinyCharacterComponent
{
    public Int64 membershipId {get;set;}
    public Int32 membershipType {get;set;}
    public Int64 characterId {get;set;}
    public DateTime dateLastPlayed {get;set;}
    public Int64 minutesPlayedThisSession {get;set;}
    public Int64 minutesPlayedTotal {get;set;}
    public Int32 light {get;set;}
    public Dictionary<UInt32, Int32 > stats {get;set;}

    /*  Use this hash to look up the character's DestinyRaceDefinition.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyRaceDefinition  */
    public UInt32 raceHash {get;set;}
    /*  Use this hash to look up the character's DestinyGenderDefinition.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyGenderDefinition  */
    public UInt32 genderHash {get;set;}
    public UInt32 classHash {get;set;}
    public Int32 raceType {get;set;}
    public Int32 classType {get;set;}
    public Int32 genderType {get;set;}
    /*  The hash of the currently equipped emblem for the user. Can be used to look up the DestinyInventoryItemDefinition.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    public string emblemPath {get;set;}
    public string emblemBackgroundPath {get;set;}
    public UInt32 emblemHash {get;set;}
    public DestinyColor emblemColor {get;set;}
    public DestinyProgression levelProgression {get;set;}
    public Int32 baseCharacterLevel {get;set;}
    public float percentToNextLevel {get;set;}
    /*  If this Character has a title assigned to it, this is the identifier of the DestinyRecordDefinition that has that title information.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Records.DestinyRecordDefinition  */
    public UInt32 titleRecordHash {get;set;}


}
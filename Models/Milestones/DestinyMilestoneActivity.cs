namespace bulkybook.Models;
public enum ActivityModeType 
{
    None = 0,
    Story = 2,
    Strike = 3,
    Raid = 4,
    AllPvP = 5,
    Patrol = 6,
    AllPvE = 7,
    Reserved9 = 9,
    Control = 10,
    Reserved11 = 11,
    Clash = 12,
    Reserved13= 13,
    CrimsonDoubles= 15,
    Nightfall= 16,
    HeroicNightfall= 17,
    AllStrikes= 18,
    IronBanner= 19,
    Reserved20 = 20,
    Reserved21 = 21,
    Reserved22 = 22,
    Reserved24 = 24,
    AllMayhem = 25,
    Reserved26 = 26,
    Reserved27 = 27,
    Reserved28 = 28,
    Reserved29 = 29,
    Reserved30 = 30,
    Supremacy = 31,
    PrivateMatchesAll = 32,
    Survival = 37,
    Countdown = 38,
    TrialsOfTheNine = 39,
    Social = 40,
    TrialsCountdown = 41,
    TrialsSurvival = 42,
    IronBannerControl = 43,
    IronBannerClash = 44,
    IronBannerSupremacy = 45,
    ScoredNightfall = 46,
    ScoredHeroicNightfall = 47,
    Rumble = 48,
    AllDoubles = 49,
    Doubles = 50,
    PrivateMatchesClash = 51,
    PrivateMatchesControl = 52,
    PrivateMatchesSupremacy = 53,
    PrivateMatchesCountdown = 54,
    PrivateMatchesSurvival = 55,
    PrivateMatchesMayhem = 56,
    PrivateMatchesRumble = 57,
    HeroicAdventure = 58,
    Showdown = 59,
    Lockdown = 60,
    Scorched = 61,
    ScorchedTeam = 62,
    Gambit = 63,
    AllPvECompetitive = 64,
    Breakthrough = 65,
    BlackArmoryRun = 66,
    Salvage = 67,
    IronBannerSalvage = 68,
    PvPCompetitive = 69,
    PvPQuickplay = 70,
    ClashQuickplay = 71,
    ClashCompetitive = 72,
    ControlQuickplay = 73,
    ControlCompetitive = 74,
    GambitPrime = 75,
    Reckoning = 76,
    Menagerie = 77,
    VexOffensive = 78,
    NightmareHunt = 79,
    Elimination = 80,
    Momentum = 81,
    Dungeon = 82,
    Sundial = 83,
    TrialsOfOsiris = 84,
    Dares = 85,
    Offensive = 86


}
public class DestinyMilestoneActivity
{
    /*  The hash of an arbitrarily chosen variant of this activity. We'll go ahead and call that the "canonical" activity, because if you're using this value you should only use it for properties that are common across the variants: things like the name of the activity, it's location, etc... Use this hash to look up the DestinyActivityDefinition of this activity for rendering data.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyActivityDefinition  */
    public UInt32 activityHash {get;set;}
    public ActivityModeType activityModeType {get;set;}
    /*  If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data. Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what's really live.
Type: array
Array Contents: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.ActivityModifiers.DestinyActivityModifierDefinition  */
    public List<UInt32> modifierHashes {get;set;}
    public List<DestinyMilestoneActivityVariant> variants {get;set;}
    

}
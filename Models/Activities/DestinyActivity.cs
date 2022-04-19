namespace bulkybook.Models;

public class DestinyActivity
{
    public UInt32 activityHash {get;set;}
    public Boolean isNew {get;set;}
    public Boolean canJoin {get;set;}
    public Boolean isCompleted {get;set;}
    public Boolean isVisible {get;set;}
    public Int32 displayLevel {get;set;}
    public Int32 recommendedLight {get;set;}
    public Int32 difficultyTier {get;set;}
    public List<DestinyChallengeStatus> challenges {get;set;}
    /*  If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.

Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what's really live.
Type: array
Array Contents: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.ActivityModifiers.DestinyActivityModifierDefinition  */
    public List<UInt32> modifierHashes {get;set;}
    public Dictionary<UInt32, Boolean> booleanActivityOptions {get;set;}
    public Int32 loadoutRequirementIndex {get;set;}
    
}
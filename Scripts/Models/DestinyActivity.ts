import { DestinyChallengeStatus } from "./DestinyChallengeStatus";
export interface DestinyActivity
{
    activityHash: number;
    isNew: boolean;
    canJoin: boolean;
    isCompleted: boolean;
    isVisible: boolean;
    displayLevel: number;
    recommendedLight: number;
    difficultyTier: number;
    challenges: Array<DestinyChallengeStatus>;
    /*  If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.

Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what's really live.
Type: array
Array Contents: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.ActivityModifiers.DestinyActivityModifierDefinition  */
    modifierHashes: Array<number> ;
    booleanActivityOptions:  Map<number, boolean>;
    loadoutRequirementIndex: number;
}
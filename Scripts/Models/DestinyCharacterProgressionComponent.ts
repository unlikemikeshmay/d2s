import { DestinyProgression } from "./DestinyProgression";
import { DestinyFactionProgression } from "./DestinyFactionProgression";
import { DestinyMilestone } from "./DestinyMilestone";
import { DestinyQuestStatus } from "./DestinyQuestStatus";
export interface DestinyCharacterProgressionComponent
{
       /* 
A Dictionary of all known progressions for the Character, keyed by the Progression's hash.

Not all progressions have user-facing data, but those who do will have that data contained in the DestinyProgressionDefinition.
Type: object
Dictionary Contents: Destiny.DestinyProgression
Dictionary Key Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyProgressionDefinition  */
progressions : Map<number,DestinyProgression>;
/* 
A dictionary of all known Factions, keyed by the Faction's hash. It contains data about this character's status with the faction.
Type: object
Dictionary Contents: Destiny.Progression.DestinyFactionProgression
Dictionary Key Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyFactionDefinition  */
factions: Map<number,DestinyFactionProgression>;
/*  Milestones are related to the simple progressions shown in the game, but return additional and hopefully helpful information for users about the specifics of the Milestone's status.
Type: object
Dictionary Contents: Destiny.Milestones.DestinyMilestone
Dictionary Key Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Milestones.DestinyMilestoneDefinition  */
 milestones: Map<number,DestinyMilestone>;
quests: Array<DestinyQuestStatus>;
uninstancedItemObjectives: Map<number,Array<DestinyInventoryItemDefinition>>;
/*  Sometimes, you have items in your inventory that don't have instances, but still have perks (for example: Trials passage cards). This gives you the perk information for uninstanced items.

This dictionary is keyed by item hash, which you can use to look up the corresponding item definition. The value is the list of perks states for the item.
Type: object
Dictionary Contents: Destiny.Entities.Items.DestinyItemPerksComponent
Dictionary Key Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
uninstancedItemPerks: Map<number,DestinyItemPerksComponent>;
checklists: Map<number,DestinyChecklistDefinition>;
seasonalArtifact: DestinyArtifactCharacterScoped;
}
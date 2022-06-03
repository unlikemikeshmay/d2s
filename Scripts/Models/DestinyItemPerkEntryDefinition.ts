
export interface DestinyItemPerkEntryDefinition
{
    requirementDisplayString: string;
    /*  A hash identifier for the DestinySandboxPerkDefinition being provided on the item.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinySandboxPerkDefinition  */
    perkHash: number;
    perkVisibility: number;
}
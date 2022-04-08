namespace bulkybook.Models;

public class DestinyItemPerkEntryDefinition
{
    public string requirementDisplayString {get;set;}
    /*  A hash identifier for the DestinySandboxPerkDefinition being provided on the item.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinySandboxPerkDefinition  */
    public UInt32 perkHash {get;set;}
    public Int32 perkVisibility {get;set;}

}
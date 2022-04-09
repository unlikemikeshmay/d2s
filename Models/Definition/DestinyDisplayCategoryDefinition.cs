namespace bulkybook.Models;

public class DestinyDisplayCategoryDefinition
{
    public Int32 index {get;set;}
    public string identifier {get;set;}
    public UInt32 displayCategoryHash {get;set;}
    public DestinyDisplayPropertiesDefinition displayProperties {get;set;}
    public Boolean displayInBanner {get;set;}
    /*  If it exists, this is the hash identifier of a DestinyProgressionDefinition that represents the progression to show on this display category.

Specific categories can now have thier own distinct progression, apparently. So that's cool.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyProgressionDefinition  */
    public UInt32 progressionHash {get;set;}
    public Int32 sortOrder {get;set;}
    public UInt32 displayStyleHash {get;set;}
     public string displayStyleIdentifier {get;set;}
}  
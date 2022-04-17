namespace bulkybook.Models;

public class DestinyChecklistEntryDefinition
{
    public UInt32 hash {get;set;}
    public DestinyDisplayPropertiesDefinition displayProperties {get;set;}
    public UInt32 destinationHash {get;set;}
    /*  Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyLocationDefinition  */
    public UInt32 locationHash {get;set;}
    public UInt32 bubbleHash {get;set;}
    public UInt32 activityHash {get;set;}
    public UInt32 vendorHash {get;set;}
    public Int32 vendorInteractionIndex {get;set;}
    public Int32 scope {get;set;}


}
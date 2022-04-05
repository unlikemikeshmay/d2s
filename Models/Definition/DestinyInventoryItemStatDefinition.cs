namespace bulkybook.Models;

public class DestinyInventoryItemStatDefinition
{
    /*  The hash for the DestinyStatDefinition representing this stat.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyStatDefinition  */
    public UInt32 statHash {get;set;}
    public Int32 value {get;set;}
    public Int32 minimum {get;set;}
    public Int32 maximum {get;set;}
    public Int32 displayMaximum {get;set;}
    
}
namespace bulkybook.Models;

public class DestinyItemInvestmentStatDefinition
{
    /*  The hash identifier for the DestinyStatDefinition defining this stat.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyStatDefinition  */
    public UInt32 statTypeHash {get;set;}
    public Int32 value {get;set;}
    public Boolean isConditionallyActive {get;set;}

}
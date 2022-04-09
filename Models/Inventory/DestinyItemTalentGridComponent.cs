namespace bulkybook.Models;

public class DestinyItemTalentGridComponent
{
    /*  Most items don't have useful talent grids anymore, but Builds in particular still do.

You can use this hash to lookup the DestinyTalentGridDefinition attached to this item, which will be crucial for understanding the node values on the item.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyTalentGridDefinition  */
    public UInt32 talentGridHash {get;set;}
    public List<DestinyTalentNode> nodes {get;set;}
    public Boolean isGridComplete {get;set;}
    public DestinyProgression gridProgression {get;set;}
}
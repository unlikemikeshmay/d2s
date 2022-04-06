namespace bulkybook.Models;

public class DestinyItemMetricBlockDefinition
{
    /*  Hash identifiers for any DestinyPresentationNodeDefinition entry that can be used to list available metrics. Any metric listed directly below these nodes, or in any of these nodes' children will be made available for selection.
Type: array
Array Contents: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Presentation.DestinyPresentationNodeDefinition  */
    public List<UInt32> availableMetricCategoryNodeHashes {get;set;}

}
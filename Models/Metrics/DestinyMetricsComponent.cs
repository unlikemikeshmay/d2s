namespace bulkybook.Models;

public class DestinyMetricsComponent
{
    public Dictionary<UInt32,DestinyMetricComponent> metrics {get;set;}
    /*  Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Presentation.DestinyPresentationNodeDefinition  */
    public UInt32 metricsRootNodeHash {get;set;}

}
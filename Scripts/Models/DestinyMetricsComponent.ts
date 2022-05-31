import { DestinyMetricComponent } from "./DestinyMetricComponent";
export interface DestinyMetricsComponent
{
    metrics: Map<number,DestinyMetricComponent>;
    /*  Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Presentation.DestinyPresentationNodeDefinition  */
    metricsRootNodeHash: number;
}
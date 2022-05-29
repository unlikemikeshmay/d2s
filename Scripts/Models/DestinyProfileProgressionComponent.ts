import { DestinyChecklistDefinition } from "./DestinyChecklistDefinition";
import { DestinyArtifactProfileScoped } from "./DestinyArtifactProfileScoped";
export interface DestinyProfileProgressionComponent
{
    checklists: Map<number,DestinyChecklistDefinition>;
    seasonalArtifact: DestinyArtifactProfileScoped;
}
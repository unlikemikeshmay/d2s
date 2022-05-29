import { DestinyPlugSetDefinition } from "./DestinyPlugSetDefinition";
export interface DestinyPlugSetsComponent
{
    plugs: Map<number, Array<DestinyPlugSetDefinition>>;
}
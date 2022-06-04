import { DestinyCraftableSocketComponent } from "./DestinyCraftableSocketComponent";
export interface DestinyCraftableComponent
{
    visible: boolean;
    failedRequirementIndexes: Array<number>;
    sockets: Array<DestinyCraftableSocketComponent>;
}
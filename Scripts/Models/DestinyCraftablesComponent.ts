import { DestinyCraftableComponent } from "./DestinyCraftableComponent";
export interface DestinyCraftablesComponent
{
    craftables: Map<number,DestinyCraftableComponent>;
    craftingRootNodeHash: number;
}
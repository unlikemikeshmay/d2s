import { DestinyCraftableSocketPlugComponent } from "./DestinyCraftableSocketPlugComponent";
export interface DestinyCraftableSocketComponent
{
    plugSetHash: number;
    plugs: Array<DestinyCraftableSocketPlugComponent>;
}
import { DestinyVendorDefinition } from "./DestinyVendorDefinition";
export interface DestinyKiosksComponent
{
    kioskItems: Map<number, Array<DestinyVendorDefinition>>;
}
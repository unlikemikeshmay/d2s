import { DestinyDerivedItemDefinition } from "./DestinyDerivedItemDefinition";
export interface DestinyDerivedItemCategoryDefinition
{
    categoryDescription: string;
    items : Array<DestinyDerivedItemDefinition>;
}

export interface DestinyItemRenderComponent
{
    useCustomDyes: boolean;
    //key = Art Arrangement Region Index

//value = The chosen Arrangement Index for the Region, based on the value of a stat on the item used for making the choice. 
    artRegions: Map<number,number>;
}
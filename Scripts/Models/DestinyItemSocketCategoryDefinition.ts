
export interface DestinyItemSocketCategoryDefinition
{
        /*  The hash for the Socket Category: a quick way to go get the header display information for the category. Use it to look up DestinySocketCategoryDefinition info.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.Sockets.DestinySocketCategoryDefinition  */
socketCategoryHash: number;
socketIndexes: Array<number>;
}
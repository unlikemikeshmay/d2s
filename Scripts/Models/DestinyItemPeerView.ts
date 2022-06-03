import { DyeReference } from "./DyeReference";

export interface DestinyItemPeerView
{
    itemHash: number;
    dyes: Array<DyeReference>;
}
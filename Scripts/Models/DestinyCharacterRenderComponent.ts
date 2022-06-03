import { DyeReference } from "./DyeReference";
import { DestinyCharacterCustomization } from "./DestinyCharacterCustomization";
import { DestinyCharacterPeerView } from "./DestinyCharacterPeerView";
export interface DestinyCharacterRenderComponent
{
    customDyes: Array<DyeReference>;
    customization: DestinyCharacterCustomization;
    peerView: DestinyCharacterPeerView;
}
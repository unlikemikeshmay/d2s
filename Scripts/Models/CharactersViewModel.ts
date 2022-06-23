import { GetDestinyCharacterResponse } from "./GetDestinyCharacterResponse";
import { GetProfileResponse } from "./GetProfileResponse";
import { GetUserMembershipData } from "./GetUserMembershipData";
import { Player } from "./Player";
export interface CharactersViewModel
{   
    userMembershipData: GetUserMembershipData;
    destinyCharacterResponse: Array<GetDestinyCharacterResponse>;
    profileResponse: GetProfileResponse;
    playerData: Player;
}
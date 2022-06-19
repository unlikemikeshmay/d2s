import { Player } from "../../Models/Player";
import { GetUserMembershipData } from "../../Models/GetUserMembershipData";
import { GetProfileResponse } from "../../Models/GetProfileResponse";
import { GetDestinyCharacterResponse } from "../../Models/GetDestinyCharacterResponse";
    export interface IGetCharacters {
        GetBungieNetUserById(membership_id: number, bearer: string): Promise<Player>;
        GetMembershipDataById(membership_id: number,membership_type: number, bearer: string): Promise<GetUserMembershipData>;
        GetProfile(destinyMembershipId: number,membershipType: number,bearer: string): Promise<GetProfileResponse>;
        GetCharacter(character_id: number,destiny_membership_id: number,membership_type,bearer: string): Promise<GetDestinyCharacterResponse>;
    }

    

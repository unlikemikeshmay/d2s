import { GetUserMembershipData } from "../../Models/GetUserMembershipData";
import { Player } from "../../Models/Player";
export interface IGetCharacters {
   GetMembershipDataById(membership_id: number,membershipType:number,bearer:string): Promise<GetUserMembershipData>;
   GetBungieNetUserById(membership_id: number,bearer: string): Promise<Player>;
}
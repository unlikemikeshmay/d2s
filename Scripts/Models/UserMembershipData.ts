import {GroupUserInfoCard} from "./GroupUserInfoCard";
import { GeneralUser } from "./GeneralUser";
export interface UserMembershipData
{
    destinyMemberships: Array<GroupUserInfoCard>;
    primaryMembershipId:number;
    bungieNetUser: GeneralUser;
}
import {GroupUserInfoCard} from "./GroupUserInfoCard";
export interface UserMembershipData
{
    destinyMemberships: Array<GroupUserInfoCard>;
    primaryMembershipId:number;
    bungieNetUser: GeneralUser;
}
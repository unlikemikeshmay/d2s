import { IgnoreResponse } from "./IgnoreResponse";
export interface UserToUserContext
{
    isFollowing:boolean;
    ignoreStatus:IgnoreResponse;
    globalIgnoreEndDate:Date;
}
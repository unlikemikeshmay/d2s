import { UserMembershipData } from "./UserMembershipData";
export interface GetUserMembershipData
{
    
    Response: UserMembershipData;
    
    ErrorCode: number;
    ThrottleSeconds: number;
    
    ErrorStatus: string;
    
    Message: string;
    
    MessageData: Map<string,string>;
    
    DetailedErrorTrace: string;
}

export interface GroupUserInfoCard
{
    LastSeenDisplayName:string;
    LastSeenDisplayNameType: number;
    supplementalDisplayName: string;
    iconPath: string

    crossSaveOverride:number;
    
    applicableMembershipTypes: Array<number>;
   
    isPublic:boolean;
    membershipType:number;
    membershipId:number;
    displayName:string;

    bungieGlobalDisplayName:string;
    
    bungieGlobalDisplayNameCode:number;
}

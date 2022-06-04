export interface MembershipType
{
    None: 0;
        TigerXbox: 1;
        TigerPsn: 2;
        TigerSteam: 3;
        TigerBlizzard: 4;
        TigerStadia: 5;
        TigerDemon: 10;
        BungieNext: 254;
        All: -1;
}
export interface Config
{
    clientID: string;
    apiKey: string;
    rootUrl: string;
    membershipType: MembershipType;
}
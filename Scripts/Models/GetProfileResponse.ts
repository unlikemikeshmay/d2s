
export interface GetProfileResponse {
    Response: DestinyProfileResponse;
    ErrorCode: number;
    ThrottleSeconds: number;
    ErrorStatus: string;
    Message:string;
    MessageData: Map<string,string>;
    DetailedErrorTrace: string;
}
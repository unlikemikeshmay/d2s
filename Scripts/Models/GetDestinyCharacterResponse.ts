import { DestinyCharacterResponse } from "./DestinyCharacterResponse"
export interface GetDestinyCharacterResponse
{
    Response: DestinyCharacterResponse;
    ErrorCode: number;
    ThrottleSeconds: number;
    ErrorStatus: string;
    Message: string;
    MessageData: Map<string,string>;
    DetailedErrorTrace: string;
}
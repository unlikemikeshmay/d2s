import { DestinyCharacterComponent } from "./DestinyCharacterComponent";
export interface DictionaryComponentResponseOfint64AndDestinyCharacterComponent
{
    data: Map<number,DestinyCharacterComponent>;
    privacy: number;
    disabled: boolean;
}
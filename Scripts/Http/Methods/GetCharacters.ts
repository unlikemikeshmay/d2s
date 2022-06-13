import {Player} from "../../Models/Player";
import {IGetCharacters} from "./IGetCharacters";


    export class GetCharacters implements IGetCharacters{
        private _getCharacters: IGetCharacters;
        constructor(getCharacter: IGetCharacters)
        {
            this._getCharacters = getCharacter;
        }
       
        GetCookie(name) {
            const nameLenPlus = (name.length + 1);
            return document.cookie
                .split(';')
                .map(c => c.trim())
                .filter(cookie => {
                return cookie.substring(0, nameLenPlus) === `${name}=`;
            })
                .map(cookie => {
                return decodeURIComponent(cookie.substring(nameLenPlus));
            })[0] || null;
        }
         async GetBungieNetUserById(membership_id: number, bearer: string): Promise<Player> {
           console.log(`getbungienetuser: ${membership_id}, bearer: ${bearer}`)
           
           const player: Player = await this._getCharacters.GetBungieNetUserById(membership_id,bearer);
           return player;
        }
        CallBNetUserById(): void {
            let mem_id = "membership_id";
            let bt = "bearer";
           let id =  parseInt(this.GetCookie(mem_id));
            let token = this.GetCookie(bt);
            console.log(this.GetBungieNetUserById(id,token));
        }
    }

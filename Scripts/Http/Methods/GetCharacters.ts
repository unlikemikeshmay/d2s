import { GetProfileResponse } from "../../Models/GetProfileResponse";
import { GetUserMembershipData } from "../../Models/GetUserMembershipData";

import {Player} from "../../Models/Player";
import {IGetCharacters} from "./IGetCharacters";


    export class GetCharacters implements IGetCharacters{
        
        private _getCharacters: IGetCharacters;
        constructor(getCharacter: IGetCharacters)
        {
            this._getCharacters = getCharacter;
        }
        async GetProfile(destinyMembershipId: number, membershipType: number, bearer: string): Promise<GetProfileResponse> {
            let getProfileResponse: GetProfileResponse;
            let url = `https://www.bungie.net/Platform/Destiny2/${membershipType}/Profile/${destinyMembershipId}/?components=200,102,100,201,205`
            await fetch(url,{
                method:"GET",
                headers: {
                    "X-API-KEY": "811c50969fca4ca784c5d14fe290244f",
                    "Authorization": bearer,
                    "content-type": "application/json"
                }
            })
            .then(response => response.json())
            .then(data => getProfileResponse = data)
            .catch((error) => console.error("Error: ",error));
            return getProfileResponse;
        }
        async GetMembershipDataById(membership_id: number,membership_type: number, bearer: string): Promise<GetUserMembershipData> {
            let url: string = `https://www.bungie.net/Platform/User/GetMembershipsById/${membership_id}/${membership_type}/`
            let getUserMembershipData: GetUserMembershipData;
            await fetch(url,{
                method:'GET',
                headers: {
                    "X-API-KEY": "811c50969fca4ca784c5d14fe290244f",
                    "Authorization": bearer,
                    "content-type": "application/json"
                }
            }).then(response => response.json())
            .then(data => getUserMembershipData = data)
            .catch((error) => console.error("Error: ",error));
            return getUserMembershipData;
        }   
        GetMembershipplayerById(membership_id: number, bearer: string): Promise<GetUserMembershipData> {
            throw new Error("Method not implemented.");
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
            let player: Player;
            let url: string = `https://www.bungie.net/Platform/User/GetBungieNetUserById/${membership_id}/`;
            await fetch(url,{
                method: 'GET',
                headers: {
                    "X-API-KEY": "811c50969fca4ca784c5d14fe290244f",
                    "Authorization": bearer,
                    'content-type': 'application/json'
                },
                
            }).then(response => response.json())
            .then(data =>  player = data.Response)
            
            .catch((error)=> {
                console.error("Error: ",error);
            });
            return player;
        }
        /* no argument way to call getbungienetuser from browser */
        CallCharacter(): Player {
            let mem_id = "membership_id";
            let bt = "bearer";
           let id =  parseInt(this.GetCookie(mem_id));
            let token = this.GetCookie(bt);
            var player: Player;
            this.GetBungieNetUserById(id,token).then(
                data => 
                {player = data,  console.log(`player in getbungienetuserbyid .then: ${player.displayName}`)} );
            console.log(`player: ${player}`);
            return  player;
            
        }
    }

    
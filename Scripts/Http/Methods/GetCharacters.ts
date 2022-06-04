import { GetUserMembershipData } from "../../Models/GetUserMembershipData"; 
import { IGetCharacters } from "./IGetCharacters";
import {Config} from "../../Config/config";
import { Player } from "../../Models/Player";
let config: Config = require('../../config.json')

class GetCharacters implements IGetCharacters {
    GetBungieNetUserById(membership_id: number, bearer: string): Promise<Player> {
        throw new Error("Method not implemented.");
    }
    

    async GetMembershipDataById(membership_id: number, membershipType: number, bearer: string): Promise<GetUserMembershipData> {
        
            let url: string = config.rootUrl + `/User/GetMembershipsById/${membership_id}/${membershipType}/`;
            const response = await fetch(url,{
                method: 'GET',
                headers: {
                    "X-API-Key": config.apiKey,
                    "Authorization": bearer
                }
            }).then(response => response.json())
            .catch((error)=> {
                console.error("Error: ",error);
            })
            console.log("response: ",response);
            return response;
    }
    
}
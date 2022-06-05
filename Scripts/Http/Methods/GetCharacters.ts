import { GetUserMembershipData } from "../../Models/GetUserMembershipData"; 
import { IGetCharacters } from "./IGetCharacters";
import {Config} from "../../Config/config";
import { Player } from "../../Models/Player";
let config: Config = require('../../config.json')

class GetCharacters implements IGetCharacters {
    
  async  GetBungieNetUserById(membership_id: number, bearer: string): Promise<Player> {
        let url: string = `https://www.bungie.net/Platform/User/GetBungieNetUserById/${membership_id}/`;
        const response = await fetch(url,{
            method: 'GET',
            headers: {
                "x-api-key": config.apiKey,
                "Authorization": bearer,
                'content-type': 'application/json'
            },
            
        }).then(response => response.json())
        .catch((error)=> {
            console.error("Error: ",error);
        })
        console.log(response)
        return response
    }
    

    async GetMembershipDataById(membership_id: number, membershipType: number, bearer: string): Promise<GetUserMembershipData> {
        
            let url: string = `https://www.bungie.net/Platform/User/GetMembershipsById/${membership_id}/${membershipType}/`;
            const response = await fetch(url,{
                method: 'GET',
                headers: {
                    "x-api-key": config.apiKey,
                    "Authorization": bearer,
                    'content-type': 'application/json'
                }
            }).then(response => response.json())
            .catch((error)=> {
                console.error("Error: ",error);
            })
            console.log("response: ",response);
            return response;
    }
    
}
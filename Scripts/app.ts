import { GetCharacters } from "./Http/Methods/GetCharacters"
import { DestinyInventoryComponent } from "./Models/DestinyInventoryComponent";
import { GetDestinyCharacterResponse } from "./Models/GetDestinyCharacterResponse";
import { GetProfileResponse } from "./Models/GetProfileResponse";
import { Player } from "./Models/Player";
import { DestinyCharacterComponent } from "./Models/DestinyCharacterComponent";

const characterSorter = (character: DestinyCharacterComponent) => {

}
const startPopulating = (charArray: Array<GetDestinyCharacterResponse>) => {
    if(charArray.length !== 3){
        console.log(`globalCharacterArray len: ${charArray.length}`)
    }else{
        console.log("did it");
        console.log(charArray);
        
        
    }
    
}

function IsNotNullOrUndefined<T>(object: T | undefined | null): object is T {
    return <T>object !== undefined && <T>object !== null;
}
const PopulateCharacterInventories = (getProfileResponse: GetProfileResponse,membership_type,membership_id) => {
    console.log("PopulateCharacterInventories is called:");
    try
    {

    if(IsNotNullOrUndefined(getProfileResponse)){
        //
        //assign ease of life variables
        let mem_id = "membership_id";
            let bt = "bearer";
            let id =  parseInt(GetCharacters.prototype.GetCookie(mem_id));
            let token = GetCharacters.prototype.GetCookie(bt);
        var charArray = Array<GetDestinyCharacterResponse>();
        // iterate through characterinventories map
        
        //get characterids
        for (let key in getProfileResponse.Response.characterInventories.data){
            let i = 0;
            //globalCharacterIds.push(key);
                GetCharacters.prototype.GetCharacter(parseInt(key),membership_id,membership_type,token)
                .then(data => {
                    charArray.push(data);
                })
                .then(data => {
                    startPopulating(charArray);
                })
                .catch((error) => console.error("Error: ",error));
        }

        
        //lookup character by characterid

        //build innerhtml list of inventory items based on character type in respective views
    }else{
        console.error("Error: GetProfileResponse Passed to populatecharacterinventories is null or undefined:: ",getProfileResponse)
    }
}catch{
    //todo: add appropriate error message:
    throw new Error("guess populate didnt work lol");
}

    
}
    if(document.readyState == 'complete')
    {
        console.log("document.ready state is complete; ")
        
    }else {
      // Attention!!!! these chained promises will contain almost all of the necessary profile info.
      // pay attention to this when setting and refreshing cookies and doing login!!!!
            let mem_id = "membership_id";
            let bt = "bearer";
            let id =  parseInt(GetCharacters.prototype.GetCookie(mem_id));
            let token = GetCharacters.prototype.GetCookie(bt);
            let player: Player;
            GetCharacters.prototype.GetBungieNetUserById(id,token)
            .then(
                player => {
                    //i believe the -1 tag is for all platforms so you can call getmembershipdatabyid,
                    //this is relevant because you need getmebershipdatabyid to get destinymembershipid
                    //to call get profile you need destinymembership id but the response contains membershiptype- which was needed in the prior request???
                    
                    GetCharacters.prototype.GetMembershipDataById(player.membershipId,-1,token)
                    .then(data => {
                        console.log(`data in getmembershipbyid: ${data.Response.destinyMemberships[0].membershipType}`);
                        //set these as vars to passthem into the populate character inventories so i can use them
                        //down the line when access is lost
                        var membershipId = data.Response.destinyMemberships[0].membershipId;
                        var membershipType = data.Response.destinyMemberships[0].membershipType;
                        GetCharacters.prototype.GetProfile(data.Response.destinyMemberships[0].membershipId,data.Response.destinyMemberships[0].membershipType,token)
                        .then(
                            data => {
                                PopulateCharacterInventories(data,membershipType,membershipId)
                                /* console.log(`data test: ${data.Response.characterInventories.data}`); */
                            }
                        )
                    })

                }
            )
            
            .catch((error) => console.error("Error: ",error));
    }


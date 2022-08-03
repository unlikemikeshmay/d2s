import { GetCharacters } from "./Http/Methods/GetCharacters"
import { DestinyInventoryComponent } from "./Models/DestinyInventoryComponent";
import { GetDestinyCharacterResponse } from "./Models/GetDestinyCharacterResponse";
import { GetProfileResponse } from "./Models/GetProfileResponse";
import { Player } from "./Models/Player";
import { DestinyCharacterComponent } from "./Models/DestinyCharacterComponent";
import { CharactersViewModel } from "./Models/CharactersViewModel";
import { GetUserMembershipData } from "./Models/GetUserMembershipData";
var player = {} as Player;
var charactersViewModel = {} as CharactersViewModel;
const PROFILE_RESPONSE = "PROFILERESPONSE";
const GET_MEMBERSHIP_DATA = "GETMEMBERSHIPDATA";
const PLAYER = "PLAYER";

const characterSorter = (character: DestinyCharacterComponent) => {

}
const startPopulatingCharacters = () => {
  console.log(`startpopulatingcharacters: ${charactersViewModel.profileResponse.Response.characters.data}`)
}

function IsNotNullOrUndefined<T>(object: T | undefined | null): object is T {
    return <T>object !== undefined && <T>object !== null;
}


const PopulateCharacterInventories = (charactersViewModel: CharactersViewModel) => {
    console.log("& * & * & * PopulateCharacterInventories is called:");
    var charactersViewModel: CharactersViewModel;
    try
    {

    if(IsNotNullOrUndefined(charactersViewModel.profileResponse)){
        //
        //assign ease of life variables
        let mem_id = "membership_id";
            let bt = "bearer";
            let id =  parseInt(GetCharacters.prototype.GetCookie(mem_id));
            let token = GetCharacters.prototype.GetCookie(bt);
            var membership_id = charactersViewModel.userMembershipData.Response.destinyMemberships[0].membershipId;
            var membership_type = charactersViewModel.userMembershipData.Response.destinyMemberships[0].membershipType;
    
        // iterate through characterinventories map
        
        //get characterids
        for (let key in charactersViewModel.profileResponse.Response.characterInventories.data){
            let i = 0;
           
            //globalCharacterIds.push(key);
                GetCharacters.prototype.GetCharacter(parseInt(key),membership_id,membership_type,token)
                .then(data => {
                    charactersViewModel.destinyCharacterResponse.push(data);
                    
                })
                .then(data => {
                    startPopulatingCharacters();
                })
                .catch((error) => console.error("Error: ",error));
        }

        
        //lookup character by characterid

        //build innerhtml list of inventory items based on character type in respective views
    }else{
        console.error("Error: GetProfileResponse Passed to populatecharacterinventories is null or undefined:: ",charactersViewModel.profileResponse)
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
            let id = GetCharacters.prototype.GetCookie(mem_id);
            let ParsedId =  parseInt(GetCharacters.prototype.GetCookie(mem_id));
            let token = GetCharacters.prototype.GetCookie(bt);
            let player: Player;
            
            console.log(`id: ${id}`);
            console.log(`parseid: ${ParsedId}`);

            //1

            GetCharacters.prototype.GetBungieNetUserById(ParsedId,token)
            .then(player => {
                //AssignGlobalVariable(player,PLAYER,charactersViewModel);
                    //i believe the -1 tag is for all platforms so you can call getmembershipdatabyid,
                    //this is relevant because you need getmebershipdatabyid to get destinymembershipid
                    //to call get profile you need destinymembership id but the response contains membershiptype- which was needed in the prior request???
                    console.log(`player: ${player.displayName}`);
                    //var memData: GetUserMembershipData;
                    charactersViewModel.playerData = player;

            //2  
                   
                    return charactersViewModel;
                })

            //3
            .then(data => {
               
                GetCharacters.prototype.GetMembershipDataById(data.playerData.membershipId,-1,token).then(data => {
 

                    charactersViewModel.userMembershipData = data;
                    
                    
                })
                return charactersViewModel;
            })
            .then(data => {

                 
                    console.log("data in third then after being passed veiwmodel with membershipdata: ",data)

                    GetCharacters.prototype.GetProfile(data.userMembershipData.Response.destinyMemberships[0].membershipId,data.userMembershipData.Response.destinyMemberships[0].membershipType,token)
                    .then(
                        data => {
                            charactersViewModel.profileResponse =  data;
                            startPopulatingCharacters();
                        }
                        
                    )
                    
            })
            ////4

                .catch((error) => console.error("Error in PopulateCharacterInventories: ",error)); 

    }


 
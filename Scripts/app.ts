import { GetCharacters } from "./Http/Methods/GetCharacters"
import { DestinyInventoryComponent } from "./Models/DestinyInventoryComponent";
import { GetDestinyCharacterResponse } from "./Models/GetDestinyCharacterResponse";
import { GetProfileResponse } from "./Models/GetProfileResponse";
import { Player } from "./Models/Player";
import { DestinyCharacterComponent } from "./Models/DestinyCharacterComponent";
import { CharactersViewModel } from "./Models/CharactersViewModel";
var charactersViewModel: CharactersViewModel;
const characterSorter = (character: DestinyCharacterComponent) => {

}
const startPopulatingCharacters = (charactersViewModel: CharactersViewModel) => {
    if(charactersViewModel.destinyCharacterResponse.length !== 3){
        console.log(`globalCharacterArray len: ${charactersViewModel.destinyCharacterResponse.length}`)
    }else{
        console.log("did it");
        console.log(charactersViewModel.destinyCharacterResponse);
        console.log(charactersViewModel.destinyCharacterResponse.length);
        console.log(`charactersViewModel.playerData.displayName: ${charactersViewModel.playerData.displayName}`);
        document.getElementById("username").innerHTML = charactersViewModel.playerData.displayName;

        
    }
    
}

function IsNotNullOrUndefined<T>(object: T | undefined | null): object is T {
    return <T>object !== undefined && <T>object !== null;
}
const PopulateCharacterInventories = (charactersViewModel: CharactersViewModel) => {
    console.log("PopulateCharacterInventories is called:");
    // i have profile and characters in this function:;:::
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
                    startPopulatingCharacters(charactersViewModel);
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
            let id =  parseInt(GetCharacters.prototype.GetCookie(mem_id));
            let token = GetCharacters.prototype.GetCookie(bt);
            let player: Player;
            
            
            GetCharacters.prototype.GetBungieNetUserById(id,token)
            .then(player => {
                    //i believe the -1 tag is for all platforms so you can call getmembershipdatabyid,
                    //this is relevant because you need getmebershipdatabyid to get destinymembershipid
                    //to call get profile you need destinymembership id but the response contains membershiptype- which was needed in the prior request???
                    var charactersViewModel: CharactersViewModel;
                    charactersViewModel.playerData = player;
                    console.log(`info in first getbungienetuserbyid: ${charactersViewModel}`);
                    return GetCharacters.prototype.GetMembershipDataById(player.membershipId,-1,token);
                })

            .then(data => {
                    console.log(`data in getmembershipbyid: ${data.Response.destinyMemberships[0].membershipType}`);
                    //set these as vars to passthem into the populate character inventories so i can use them
                    //down the line when access is lost
                    var charactersViewModel: CharactersViewModel;
                    charactersViewModel.userMembershipData = data;
                    return charactersViewModel;
                    })
            .then(data => {
                    
                    GetCharacters.prototype.GetProfile(data.userMembershipData.Response.destinyMemberships[0].membershipId,data.userMembershipData.Response.destinyMemberships[0].membershipType,token)
                    .then(data => {
                        var charactersViewModel: CharactersViewModel;
                        return charactersViewModel.profileResponse = data;
                    })
                    .catch(error => console.log(`Error: ${error}`));
                    console.log(`charactersViewModel.profileResonse after it was assigned in .this() ${charactersViewModel.profileResponse}`);
                    return charactersViewModel;
                })
            .then(data => {
                console.log(`charactersViewModel.profileResonse after it was assigned in .this()`);
                console.log(`charactersViewModel before it is sent to populatecharacterinventories: ${charactersViewModel}`);
                    PopulateCharacterInventories(data);
                    /* console.log(`data test: ${data.Response.characterInventories.data}`); */
                            
                    })
            .catch((error) => console.error("Error: ",error));
    }

/*             .then(
                player => {
                    //i believe the -1 tag is for all platforms so you can call getmembershipdatabyid,
                    //this is relevant because you need getmebershipdatabyid to get destinymembershipid
                    //to call get profile you need destinymembership id but the response contains membershiptype- which was needed in the prior request???
                    
                    charactersViewModel.playerData = player;
                    console.log(`info in first getbungienetuserbyid: ${charactersViewModel}`);
                    GetCharacters.prototype.GetMembershipDataById(player.membershipId,-1,token)
                    .then(data => {
                        console.log(`data in getmembershipbyid: ${data.Response.destinyMemberships[0].membershipType}`);
                        //set these as vars to passthem into the populate character inventories so i can use them
                        //down the line when access is lost
                       
                        charactersViewModel.userMembershipData = data;
                        var membershipId = data.Response.destinyMemberships[0].membershipId;
                        var membershipType = data.Response.destinyMemberships[0].membershipType;
                        GetCharacters.prototype.GetProfile(data.Response.destinyMemberships[0].membershipId,data.Response.destinyMemberships[0].membershipType,token)
                        .then(
                            data => {
                                charactersViewModel.profileResponse = data;
                                PopulateCharacterInventories(charactersViewModel);
                                /* console.log(`data test: ${data.Response.characterInventories.data}`); */
 
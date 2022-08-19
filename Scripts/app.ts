import { GetCharacters } from "./Http/Methods/GetCharacters"
import { DestinyInventoryComponent } from "./Models/DestinyInventoryComponent";
import { GetDestinyCharacterResponse } from "./Models/GetDestinyCharacterResponse";
import { GetProfileResponse } from "./Models/GetProfileResponse";
import { Player } from "./Models/Player";
import { DestinyCharacterComponent } from "./Models/DestinyCharacterComponent";
import { CharactersViewModel } from "./Models/CharactersViewModel";
import { GetUserMembershipData } from "./Models/GetUserMembershipData";
import { CharacterList } from "./Models/CharacterList";
var player = {} as Player;
var charactersViewModel = {} as CharactersViewModel;
var characterList = [] as Array<DestinyCharacterComponent>;
const PROFILE_RESPONSE = "PROFILERESPONSE";
const GET_MEMBERSHIP_DATA = "GETMEMBERSHIPDATA";
const PLAYER = "PLAYER";
const characterFocus = ( event:Event) => {
    event.preventDefault();
    var button = document.getElementById("dropdownCharacters");
     button.innerHTML = event.target["innerHTML"]
     //set body of list to a spinner then call method to populate it.
     //good luck me 

}
const ClassTypeConverter = (hash: number): string => {
    var conversion: string;
    switch(hash){
        case 0:
            //console.log("hash: ",hash);
            conversion = "Titan";
            break;
        case 1:
            //console.log("hash: ",hash);
            conversion = "Hunter";
            break;
        case 2:
            //console.log("hash: ",hash);
            conversion = "Warlock";
            break;
        default:
            //console.log("hash: ",hash);
            conversion = "Unknown";
            break;
    }
    console.log("watchify changed");
    return conversion;
    
}
const characterSorter = (charactersviewmodel: CharactersViewModel) => {
    let bt = "bearer";
    let token = GetCharacters.prototype.GetCookie(bt);
    var ul = document.getElementById("dropdownCharactersUl");
    var data = charactersViewModel.profileResponse.Response.characters.data;
    var iterator = 0;
    
    for (var key in data){

        let value = data[key];
        console.log("data in charsorter: ",value);
        console.log("data in charsorter: membershipid ",value.membershipId);
        console.log("data in charsorter: characterid",value.characterId);
        console.log("data in charsorter: memtype",value.membershipType);
        var character = {} as DestinyCharacterComponent;
        GetCharacters.prototype.GetCharacter(value.characterId,value.membershipId,value.membershipType,token).then(
            data => {
                //console.log(`getdestinycharacterresponse iteration ${key}: ${classTypeConverter(data.Response.character.data.classType)}`);
                character = data.Response.character.data
                //console.log("character: ",character);
                characterList.push(character);
                //console.log(`characterList: ${characterList}`);
                return characterList
            }
        ).then(data => {
            console.log("iterator: ",iterator);
        console.log("charlist: ",data);
       ;
        var li = document.createElement("li");
        var nodeText = ClassTypeConverter(data[iterator].classType);
        li.appendChild(document.createTextNode(nodeText));
        li.setAttribute("class","dropdown-item");
        li.addEventListener("click",characterFocus,);
        ul.appendChild(li);
       // console.log("characters: ",characters[i]);
       iterator++;
        })
        
    }
 
}
const startPopulatingCharacters = () => {

    var characters: string[][];
  // console.log(`inside startpopulatingcharacters ${charactersViewModel.profileResponse.Response.characterInventories.data.values.length}`)
  console.log("startpop called with charactersviewmodel: ",charactersViewModel.playerData.displayName);
  var username = document.getElementById("username");
  username.innerHTML = charactersViewModel.playerData.displayName;

  characterSorter(charactersViewModel);


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

            var getchars = Promise.resolve(GetCharacters.prototype.GetBungieNetUserById(ParsedId,token));
            getchars
            .then(player => {
                //AssignGlobalVariable(player,PLAYER,charactersViewModel);
                    //i believe the -1 tag is for all platforms so you can call getmembershipdatabyid,
                    //this is relevant because you need getmebershipdatabyid to get destinymembershipid
                    //to call get profile you need destinymembership id but the response contains membershiptype- which was needed in the prior request???
                    console.log(`player: ${player.displayName}`);
                    //var memData: GetUserMembershipData;
                    charactersViewModel.playerData = player;

                return charactersViewModel.playerData;})
             //2   
                .then(data => {
                    console.log("promise.resolve getmembyid ",Promise.resolve(GetCharacters.prototype.GetMembershipDataById(data.membershipId,-1,token)));
                    /* charactersViewModel.userMembershipData */
                    var memid = Promise.resolve(GetCharacters.prototype.GetMembershipDataById(data.membershipId,-1,token));
                    charactersViewModel.playerData = data;
                      console.log("charactersviewmodel being returned from second then: ",charactersViewModel);
                      return memid;
                  })
                
            //3
                .then(data => {
                    charactersViewModel.userMembershipData = data;
                    //var profileResponse: GetProfileResponse;
                    console.log("data in third then after being passed veiwmodel with membershipdata: ",data)
                    /* GetCharacters.prototype.GetProfile(data.Response.bungieNetUser..userMembershipData.Response.destinyMemberships[0].membershipId,data.userMembershipData.Response.destinyMemberships[0].membershipType,token) */
                   var profile = Promise.resolve(GetCharacters.prototype.GetProfile(data.Response.destinyMemberships[0].membershipId,data.Response.destinyMemberships[0].membershipType,token));
            ////4
                    
                   return profile;
                   
                })
                .then(data => {
                    charactersViewModel.profileResponse = data;
                    console.log(`charactersViewModel.profileResonse after it was assigned in fifth .this()${data}`);
                    console.log(`charactersviewmodel after last chain ${charactersViewModel.profileResponse.Response.characters}`)
                    //console.log(`charactersViewModel before it is sent to populatecharacterinventories: ${charactersViewModel.userMembershipData.Response.bungieNetUser.displayName}`);
                   


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


 
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

const characterSorter = (charactersviewmodel: CharactersViewModel): string[] => {
    var i: number = 0;
    let characters:any[][];
    for (let key in charactersViewModel.profileResponse.Response.characters.data){
        let value = charactersViewModel.profileResponse.Response.characters.data[key];
        characters[i] = value;
        console.log("characters: ",characters);
    }
 return [];
}
const startPopulatingCharacters = () => {
    var characters: string[];
  // console.log(`inside startpopulatingcharacters ${charactersViewModel.profileResponse.Response.characterInventories.data.values.length}`)
  console.log("startpop called with charactersviewmodel: ",charactersViewModel.playerData.displayName);
  var username = document.getElementById("username");
  username.innerHTML = charactersViewModel.playerData.displayName;

  characters = characterSorter(charactersViewModel)

}

function IsNotNullOrUndefined<T>(object: T | undefined | null): object is T {
    return <T>object !== undefined && <T>object !== null;
}

function AssignGlobalVariable<T>(obj: T,trigger: string,charactersViewModel: CharactersViewModel) {
    switch(trigger){
        case PLAYER: 
            player.membershipId = obj["membershipId"];
            player.uniqueName = obj["uniqueName"];
            player.normalizedName = obj["normalizedName"];
            player.displayName = obj["displayName"];
            player.profilePicture = obj["profilePicture"];
            player.profileTheme = obj["profileTheme"];
            player.userTitle = obj["userTitle"];
            player.successMessageFlags = obj["successMessageFlags"];
            player.isDeleted = obj["isDeleted"];
            player.about = obj["about"];
            player.firstAccess = obj["firstAccess"];
            player.lastUpdate = obj["lastUpdate"];
            player.legacyPortalUID = obj["legacyPortalUID"];
            player.context = obj["context"];
            player.psnDisplayName = obj["psnDisplayName"];
            player.xboxDisplayName = obj["xboxDisplayName"];
            player.fbDisplayName = obj["fbDisplayName"];
            player.showActivity = obj["showActivity"];
            player.locale = obj["locale"];
            player.localeInheritDefault = obj["localeInheritDefault"];
            player.lastBanReportId = obj["lastBanReportId"];
            player.showGroupMessaging = obj["showGroupMessaging"];
            player.profilePicturePath = obj["profilePicturePath"];
            player.profileThemeName = obj["profileThemeName"];
            player.userTitleDisplay = obj["userTitleDisplay"];
            player.statusText = obj["statusText"];
            player.statusDate = obj["statusDate"];
            player.profileBanExpire = obj["profileBanExpire"];
            player.blizzardDisplayName = obj["blizzardDisplayName"];
            player.steamDisplayName = obj["steamDisplayName"];
            player.stadiaDisplayName = obj["stadiaDisplayName"];
            player.twitchDisplayName = obj["twitchDisplayName"];
            player.cachedBungieGlobalDisplayName = obj["cachedBungieGlobalDisplayName"];
            player.cachedBungieGlobalDisplayNameCode = obj["cachedBungieGlobalDisplayNameCode"];
            break;
        default:
            console.log("default");
    }
    console.log("after switch: ",player);
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
                    startPopulatingCharacters();
                        
                                
                        })
                .catch((error) => console.error("Error in PopulateCharacterInventories: ",error)); 

    }


 
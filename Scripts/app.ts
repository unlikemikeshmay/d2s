import { GetCharacters } from "./Http/Methods/GetCharacters"
import { Player } from "./Models/Player";
var globalPlayer: Player;
function setPlayer(player: Player){
    globalPlayer = player;
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
                    GetCharacters.prototype.GetMembershipDataById(player.membershipId,-1,token)
                    .then(data => {
                        console.log(`data in getmembershipbyid: ${data.Response.destinyMemberships[0].membershipType}`);
                        GetCharacters.prototype.GetProfile(data.Response.destinyMemberships[0].membershipId,data.Response.destinyMemberships[0].membershipType,token)
                        .then(
                            data => {
                                console.log(`data inside getprofile: ${data.Response.characterInventories.data}`)
                            }
                        )
                    })

                }
            )
            
            .catch((error) => console.error("Error: ",error));
    }
    console.log(`globalPlayer: ${globalPlayer}`)


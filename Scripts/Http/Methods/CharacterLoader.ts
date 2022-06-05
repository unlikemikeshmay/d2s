import { IGetCharacters } from "./IGetCharacters";
import { GetCookie } from "../../Helper/GetCookie";

export class CharacterLoader{
    //this is a good opportunity to check if the tokens are valid.....
    
    private _getCharacters: IGetCharacters;
    
    constructor(
        getCharacters: IGetCharacters
    ){
        this._getCharacters = getCharacters
    }
        GetCharacterInfo(){
        console.log("getCharacterinfo")
        let key = "bearer";
        let membership_id_key = "membership_id";
        let membership_id = GetCookie(membership_id_key);
        console.log("called Characterloader.getcharacterinfobyid")
        //let info = this._getCharacters.GetMembershipDataById(membership_id,)
    }
        GetBungieNetUser(){
            console.log("getbungienetuser")
        let membership_id = "membership_id";
        let bearer = "bearer";
        let id =  parseInt(GetCookie(membership_id));
        let token = GetCookie(bearer);
        let info = this._getCharacters.GetBungieNetUserById(id,token);
        console.log("getbungienetuser: ",info);
        

    }
}
if(document.readyState == 'complete'){
    console.log("if doc ready state complete: ")
    CharacterLoader.prototype.GetBungieNetUser();
}
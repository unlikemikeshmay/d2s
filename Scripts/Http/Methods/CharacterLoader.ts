import { IGetCharacters } from "./IGetCharacters";
import { Config } from "../../Config/config";
import { GetCookie } from "../../Helper/GetCookie";

export class CharacterLoader{
    //this is a good opportunity to check if the tokens are valid.....
    
    private _getCharacters: IGetCharacters;
    private _config: Config = require("../../../config.json");
    constructor(
        getCharacters: IGetCharacters
    ){
        this._getCharacters = getCharacters
    }

    getCharacterInfo = () => {
        let key = "bearer";
        let membership_id_key = "membership_id";
        let membership_id = GetCookie(membership_id_key);

        console.log("called Characterloader.getcharacterinfobyid")

        //let info = this._getCharacters.GetMembershipDataById(membership_id,)
    }
}
if(document.readyState == 'complete'){
    console.log('complete');
  }else{
    console.log('not complete');
  }
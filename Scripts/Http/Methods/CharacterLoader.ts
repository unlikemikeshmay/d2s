import { IGetCharacters } from "./IGetCharacters";

export class CharacterLoader
{
    //this is a good opportunity to check if the tokens are valid.....
    
    private _getCharacters: IGetCharacters;
    
    constructor(
        getCharacters: IGetCharacters
    ){
        this._getCharacters = getCharacters;
        
    }
    //pass a key/name and it returns the value or null
//if the key doesn't exist
    GetCookie(name) {
    const nameLenPlus = (name.length + 1);
    return document.cookie
        .split(';')
        .map(c => c.trim())
        .filter(cookie => {
        return cookie.substring(0, nameLenPlus) === `${name}=`;
    })
        .map(cookie => {
        return decodeURIComponent(cookie.substring(nameLenPlus));
    })[0] || null;
}
        GetCharacterInfo(): void{
        console.log("getCharacterinfo")
        let key = "bearer";
        let membership_id_key = "membership_id";
        let membership_id = CharacterLoader.prototype.GetCookie(membership_id_key);
        console.log("called Characterloader.getcharacterinfobyid")
        //let info = this._getCharacters.GetMembershipDataById(membership_id,)
    }
        GetBungieNetUser(): void{
            const characterLoader = new CharacterLoader(this._getCharacters);
            console.log("getbungienetuser")
        let membership_id = "membership_id";
        let bearer = "bearer";
        let id =  parseInt(characterLoader.GetCookie(membership_id));
        let token = characterLoader.GetCookie(bearer);
        let info = characterLoader._getCharacters.GetBungieNetUserById(id,token);
        console.log("info: ",info);
        

    }
    
    
}

let gc: IGetCharacters;
const characterLoader: CharacterLoader = new CharacterLoader(gc);
characterLoader.GetBungieNetUser();
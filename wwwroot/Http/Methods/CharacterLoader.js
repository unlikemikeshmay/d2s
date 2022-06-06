import { GetCookie } from "../../Helper/GetCookie";
export class CharacterLoader {
    constructor(getCharacters) {
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
    GetCharacterInfo() {
        console.log("getCharacterinfo");
        let key = "bearer";
        let membership_id_key = "membership_id";
        let membership_id = GetCookie(membership_id_key);
        console.log("called Characterloader.getcharacterinfobyid");
        //let info = this._getCharacters.GetMembershipDataById(membership_id,)
    }
    GetBungieNetUser() {
        console.log("getbungienetuser");
        let membership_id = "membership_id";
        let bearer = "bearer";
        let id = parseInt(GetCookie(membership_id));
        let token = GetCookie(bearer);
        let info = this._getCharacters.GetBungieNetUserById(id, token);
        console.log("getbungienetuser: ", info);
    }
}
if (document.readyState == 'complete') {
    console.log("if doc ready state complete: ");
    CharacterLoader.prototype.GetBungieNetUser();
}
//# sourceMappingURL=CharacterLoader.js.map
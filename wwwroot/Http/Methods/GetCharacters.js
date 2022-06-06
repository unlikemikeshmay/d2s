var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
let config = require('../../config.json');
class GetCharacters {
    GetBungieNetUserById(membership_id, bearer) {
        return __awaiter(this, void 0, void 0, function* () {
            let url = `https://www.bungie.net/Platform/User/GetBungieNetUserById/${membership_id}/`;
            const response = yield fetch(url, {
                method: 'GET',
                headers: {
                    "x-api-key": config.apiKey,
                    "Authorization": bearer,
                    'content-type': 'application/json'
                },
            }).then(response => response.json())
                .catch((error) => {
                console.error("Error: ", error);
            });
            console.log(response);
            return response;
        });
    }
    GetMembershipDataById(membership_id, membershipType, bearer) {
        return __awaiter(this, void 0, void 0, function* () {
            let url = `https://www.bungie.net/Platform/User/GetMembershipsById/${membership_id}/${membershipType}/`;
            const response = yield fetch(url, {
                method: 'GET',
                headers: {
                    "x-api-key": config.apiKey,
                    "Authorization": bearer,
                    'content-type': 'application/json'
                }
            }).then(response => response.json())
                .catch((error) => {
                console.error("Error: ", error);
            });
            console.log("response: ", response);
            return response;
        });
    }
}
export {};
//# sourceMappingURL=GetCharacters.js.map
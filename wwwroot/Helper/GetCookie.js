//pass a key/name and it returns the value or null
//if the key doesn't exist
export function GetCookie(name) {
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
//# sourceMappingURL=GetCookie.js.map
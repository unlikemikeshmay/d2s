 namespace Characters {
    export interface IGetCharacters {
        GetBungieNetUserById(membership_id: number, bearer: string): string;
    }
}
    

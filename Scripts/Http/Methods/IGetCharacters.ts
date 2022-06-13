import { Player } from "../../Models/Player";
    export interface IGetCharacters {
        GetBungieNetUserById(membership_id: number, bearer: string): Promise<Player>;
    }

    

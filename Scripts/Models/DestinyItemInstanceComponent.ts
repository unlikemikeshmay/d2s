import { DestinyStat } from "./DestinyStat";
import { DestinyItemInstanceEnergy } from "./DestinyItemInstanceEnergy";
export interface BreakerType{
    None : 0,
    ShieldPiercing : 1,
    Disruption : 2,
    Stagger : 3
}
export interface DestinyItemInstanceComponent
{
    damageType: number;
    damageTypeHash: number;
    primaryStat: DestinyStat;
    itemLevel: number;
    quality: number;
    isEquipped: boolean;
    canEquip: boolean;
    equipRequiredLevel: number;
    // Mapped to Manifest Database Definition: Destiny.Definitions.DestinyUnlockDefinition 
    unlockHashesRequiredToEquip: Array<number>;
    cannotEquipReason: number;
    breakerType: BreakerType;
    // Mapped to Manifest Database Definition: Destiny.Definitions.BreakerTypes.DestinyBreakerTypeDefinition 
    breakerTypeHash: number;
    energy: DestinyItemInstanceEnergy;
}
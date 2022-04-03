namespace bulkybook.Models;
public enum BreakerType {
    None = 0,
    ShieldPiercing = 1,
    Disruption = 2,
    Stagger = 3
}
public class DestinyItemInstanceComponent
{
    public Int32 damageType {get;set;}
    public UInt32 damageTypeHash {get;set;}
    public DestinyStat primaryStat {get;set;}
    public Int32 itemLevel {get;set;}
    public Int32 quality {get;set;}
    public Boolean isEquipped {get;set;}
    public Boolean canEquip {get;set;}
    public Int32 equipRequiredLevel {get;set;}
    // Mapped to Manifest Database Definition: Destiny.Definitions.DestinyUnlockDefinition 
    public List<UInt32> unlockHashesRequiredToEquip {get;set;}
    public Int32 cannotEquipReason {get;set;}
    public BreakerType breakerType {get;set;}
    // Mapped to Manifest Database Definition: Destiny.Definitions.BreakerTypes.DestinyBreakerTypeDefinition 
    public UInt32 breakerTypeHash {get;set;}
    public DestinyItemInstanceEnergy energy {get;set;}

}
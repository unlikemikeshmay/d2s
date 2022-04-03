namespace bulkybook.Models;

public class DestinyItemInstanceEnergy
{
    // Mapped to Manifest Database Definition: Destiny.Definitions.EnergyTypes.DestinyEnergyTypeDefinition 
    public UInt32 energyTypeHash {get;set;}
    public Int32 energyType {get;set;}
    public Int32 energyCapacity {get;set;}
    public Int32 energyUsed {get;set;}
    public Int32 energyUnused {get;set;}
}
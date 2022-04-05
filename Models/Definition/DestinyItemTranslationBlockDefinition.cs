namespace bulkybook.Models;

public class DestinyItemTranslationBlockDefinition
{
    public string weaponPatternIdentifier {get;set;}
    public UInt32 weaponPatternHash {get;set;}
    public List<DyeReference> defaultDyes {get;set;}
    public List<DyeReference> lockedDyes {get;set;}
    public List<DyeReference> customDyes {get;set;}
    public List<DestinyGearArtArrangementReference> arrangements {get;set;}
    public Boolean hasGeometry {get;set;}
}
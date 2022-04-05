namespace bulkybook.Models;

public class DestinyEquippingBlockDefinition
{
    /*  If the item is part of a gearset, this is a reference to that gearset item.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    public UInt32 gearsetItemHash {get;set;}
    public string uniqueLabel {get;set;}
    public UInt32 uniqueLabelHash {get;set;}
    /*  An equipped item *must* be equipped in an Equipment Slot. This is the hash identifier of the DestinyEquipmentSlotDefinition into which it must be equipped.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyEquipmentSlotDefinition  */
    public UInt32 equipmentSlotTypeHash {get;set;}
    public Int32 attributes {get;set;}
    public Int32 ammoType {get;set;}
    public List<string> displayStrings {get;set;}

}

export interface DestinyEquippingBlockDefinition
{
        /*  If the item is part of a gearset, this is a reference to that gearset item.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
gearsetItemHash: number;
 uniqueLabel: string;
uniqueLabelHash: number;
/*  An equipped item *must* be equipped in an Equipment Slot. This is the hash identifier of the DestinyEquipmentSlotDefinition into which it must be equipped.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyEquipmentSlotDefinition  */
equipmentSlotTypeHash: number;
attributes: number;
ammoType: number;
displayStrings: Array<string>;
}
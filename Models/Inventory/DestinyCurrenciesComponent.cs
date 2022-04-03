namespace bulkybook.Models;

public class DestinyCurrenciesComponent
{
    /* A dictionary - keyed by the item's hash identifier (DestinyInventoryItemDefinition), and whose value is the amount of that item you have across all available inventory buckets for purchasing.

This allows you to see whether the requesting character can afford any given purchase/action without having to re-create this list itself.
 Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition 
  */
    public Dictionary<UInt32, Int32> itemQuantities {get;set;}

}
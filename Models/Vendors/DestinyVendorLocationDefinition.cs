namespace bulkybook.Models;

public class DestinyVendorLocationDefinition
{
    /*  The hash identifier for a Destination at which this vendor may be located. Each destination where a Vendor may exist will only ever have a single entry.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyDestinationDefinition  */
    public UInt32 destinationHash {get;set;}
    public string backgroundImagePath {get;set;}
}
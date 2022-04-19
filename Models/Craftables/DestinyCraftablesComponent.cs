namespace bulkybook.Models;

public class DestinyCraftablesComponent
{
    public Dictionary<UInt32,DestinyCraftableComponent> craftables {get;set;}
    public UInt32 craftingRootNodeHash {get;set;}
}